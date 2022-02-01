using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopTestApp
{
    public class DataBaseConn
    {
        public static DataBaseConn TstFilObj;

        private String LectNum, LectLstLogDate, StudNum, StudLstLogDate, testName, SelTestCont;
        private String getPath = @"Users\\";
        private string[,] readData = { { "Default Value" } };
        private string[] arrNumQues;
        private string[] arrLectAcc = new string[5], arrStudAcc = new string[5];
        private int[] arrTestMarks;
        private int numQues, TotTestMarks;

        //Set Connection String
        static String DB_Directory = Directory.GetCurrentDirectory().Replace(@"bin\Debug", "DesktopTestAppDB.mdf");
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + DB_Directory + ";Integrated Security=True");
        //Set Command
        SqlCommand cmd = new SqlCommand();

        public DataBaseConn()
        {
            TstFilObj = this;
        }

//----------------------------------------------------------------------------------------------------
        //Lecturer

        public void RegisterLecturer(String LectNum, String LectName, String LectEmail, String LectPass, String LastLoggedIn)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"INSERT INTO LectureTBL(LectNo, LectName, LectEmail, LectPass, LectLastLoggedIn) 
                              VALUES(@param1, @param2, @param3, @param4, @param5)";

                cmd.Parameters.AddWithValue("@param1", LectNum);
                cmd.Parameters.AddWithValue("@param2", LectName);
                cmd.Parameters.AddWithValue("@param3", LectEmail);
                cmd.Parameters.AddWithValue("@param4", LectPass);
                cmd.Parameters.AddWithValue("@param5", LastLoggedIn);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Adding to the database failed");
            }

            cmd.Parameters.Clear();
            conn.Close();
        }

        public bool isLecturerExit(String LectNum)
        {
            this.LectNum = LectNum;
            bool Flag = false;

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT LectNo FROM LectureTBL WHERE LectNo = @param1";
                cmd.Parameters.AddWithValue("@param1", LectNum);
                SqlDataReader sReader = cmd.ExecuteReader();

                if (sReader.HasRows)
                {
                    Flag = true;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();
            return Flag;
        }

        public bool isLecturerPassCorrect(String LectPass)
        {
            bool Flag = false;

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT * FROM LectureTBL WHERE LectNo = @param1 And LectPass = @param2";

                cmd.Parameters.AddWithValue("@param1", LectNum);
                cmd.Parameters.AddWithValue("@param2", LectPass);
                SqlDataReader sReader = cmd.ExecuteReader();

                if (sReader.HasRows)
                {
                    Flag = true;
                    LectLstLogDate = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");

                    while (sReader.Read())
                    {
                        sReader.GetValues(arrLectAcc);
                    }
                    
                    cmd.Parameters.Clear();
                    conn.Close();
                    setLectLstLogInDate();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();
            return Flag;
        }

        public string getLectNum()
        {
            return arrLectAcc[0];
        }

        public string getLectName()
        {
            return arrLectAcc[1];
        }

        public string getLectEmail()
        {
            return arrLectAcc[2];
        }

        public string getLectPass()
        {
            return arrLectAcc[3];
        }

        public string getLectLstLogDate()
        {
            return arrLectAcc[4];
        }

        public void setLectLstLogInDate()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"UPDATE LectureTBL SET LectLastLoggedIn = @param1 WHERE LectNo = @param2";

                cmd.Parameters.AddWithValue("@param1", LectLstLogDate);
                cmd.Parameters.AddWithValue("@param2", arrLectAcc[0]);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Updating database failed");
            }
        }

        public void AlterLectAccount(String LectName, String LectEmail, String LectPass)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"UPDATE lectureTBL SET LectName = @param1, LectEmail = @param2, 
                                  LectPass = @param3 WHERE LectNo = @param4";

                cmd.Parameters.AddWithValue("@param1", LectName);
                cmd.Parameters.AddWithValue("@param2", LectEmail);
                cmd.Parameters.AddWithValue("@param3", LectPass);
                cmd.Parameters.AddWithValue("@param4", arrLectAcc[0]);

                arrLectAcc[1] = LectName;
                arrLectAcc[2] = LectEmail;
                arrLectAcc[3] = LectPass;

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Updating database failed");
            }

            cmd.Parameters.Clear();
            conn.Close();
        }

        public void createLecturerTest(String testName)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"INSERT INTO TestCreatedTBL(LectNo, TestName)
                                VALUES(@param1, @param2)";

                cmd.Parameters.AddWithValue("@param1", arrLectAcc[0]);
                cmd.Parameters.AddWithValue("@param2", testName);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Adding data to database failed");
            }

            cmd.Parameters.Clear();
            conn.Close();
        }

        public void deleteLecturerTest(String testName)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"DELETE FROM TestCreatedTBL WHERE LectNo = @param1 AND TestName = @param2; 
                                    DELETE FROM QuestionsTBL WHERE LectNo = @param1 AND TestName = @param2; 
                                    DELETE FROM TestDetailsTBL WHERE LectNo = @param1 AND TestName = @param2";

                cmd.Parameters.AddWithValue("@param1", arrLectAcc[0]);
                cmd.Parameters.AddWithValue("@param2", testName);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Deleting data from database failed");
            }

            cmd.Parameters.Clear();
            conn.Close();
        }

        public void deleteLectAcc()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"DELETE FROM LectureTBL WHERE LectNo = @param1";

                cmd.Parameters.AddWithValue("@param1", arrLectAcc[0]);
                cmd.ExecuteNonQuery();
               
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Deleting data from database failed");
            }

            cmd.Parameters.Clear();
            conn.Close();
        }

//--------------------------------------------------------------------------------------------------
        // Requires the 'setLecTstPth' To Be Executed First - To set Test Path

        public void setLecTstPth(string testName)
        {
            this.testName = testName;
        }

        public void setOpenFilePath(String path)
        {
            getPath = path;
        }

        public void setLecturerTest(String LectQuestion, String LectAns1, String LectAns2, String LectAns3, String LectAns4, String LectCorrAns, int LectMarks)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"INSERT INTO QuestionsTBL(LectNo, TestName, Question, Option1, Option2, Option3, Option4, Answer, Marks) 
                                    VALUES(@param1, @param2, @param3, @param4, @param5, @param6, @param7, @param8, @param9)";

                cmd.Parameters.AddWithValue("@param1", arrLectAcc[0]);
                cmd.Parameters.AddWithValue("@param2", testName);
                cmd.Parameters.AddWithValue("@param3", LectQuestion);
                cmd.Parameters.AddWithValue("@param4", LectAns1);
                cmd.Parameters.AddWithValue("@param5", LectAns2);
                cmd.Parameters.AddWithValue("@param6", LectAns3);
                cmd.Parameters.AddWithValue("@param7", LectAns4);
                cmd.Parameters.AddWithValue("@param8", LectCorrAns);
                cmd.Parameters.AddWithValue("@param9", LectMarks);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Adding to the database failed");
            }

            cmd.Parameters.Clear();
            conn.Close();
        }

        public bool isLectTestNull()
        {
            bool Flag = true;

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT * FROM QuestionsTBL WHERE LectNo = @param1";
                cmd.Parameters.AddWithValue("@param1", arrLectAcc[0]);
                SqlDataReader sReader = cmd.ExecuteReader();

                if (sReader.HasRows)
                {
                    Flag = false;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();
            return Flag;
        }

        public string [,] readLectTest(String testName)//Readiing from QuestionsTBL
        {
            string[,] readRows = new string[0, 0];

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT Question, Option1, Option2, Option3, Option4,
                                    Answer, Marks FROM QuestionsTBL WHERE LectNo = @param1 AND TestName = @param2";

                cmd.Parameters.AddWithValue("@param1", arrLectAcc[0]);
                cmd.Parameters.AddWithValue("@param2", testName);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int rowLenght = dt.Rows.Count;
                readRows = new string[rowLenght, 7];

                int counter = 0;
                TotTestMarks = 0;

                foreach (DataRow rows in dt.Rows)
                {
                    for (int i = 0; i < 7; i++)
                    {
                        readRows[counter, i] = rows[i] + "";
                    }

                    TotTestMarks += int.Parse(rows[6]+"");
                    counter++;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();
            return readRows;
        }

//--------------------------------------------------------------------------------------------------

        public string[] getCreatedLectTests()
        {
            List<String> listTestNames = new List<string>();

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT TestName FROM TestCreatedTBL WHERE LectNo = @param1";
                cmd.Parameters.AddWithValue("@param1", arrLectAcc[0]);
                SqlDataReader sReader = cmd.ExecuteReader();

                while (sReader.Read())
                {
                    listTestNames.Add(sReader.GetSqlString(0).ToString());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();

            return listTestNames.ToArray();
        }

        public string[] getLectTests()
        {
            List<String> listTestNames = new List<string>();
            List<String> listNumQues = new List<String>();

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT TestName, NumQuestions FROM TestDetailsTBL WHERE LectNo = @param1";
                cmd.Parameters.AddWithValue("@param1", arrLectAcc[0]);
                SqlDataReader sReader = cmd.ExecuteReader();

                while (sReader.Read())
                {
                    listTestNames.Add(sReader.GetSqlString(0).ToString());
                    listNumQues.Add(sReader.GetValue(1).ToString());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();

            arrNumQues = listNumQues.ToArray();

            return listTestNames.ToArray();
        }

        public String[] getTotQues()
        {
            return arrNumQues;
        }

        public string[] getDateCreated()
        {
            List<String> listTestDates = new List<string>();

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT DateCreated FROM TestDetailsTBL WHERE LectNo = @param1";
                cmd.Parameters.AddWithValue("@param1", arrLectAcc[0]);
                SqlDataReader sReader = cmd.ExecuteReader();

                while (sReader.Read())
                {
                    listTestDates.Add(sReader.GetSqlString(0).ToString());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();

            return listTestDates.ToArray();
        }

        public void saveStudTest(String[,] arrTest)//Saving TestDetails
        {
            String DateCreated = DateTime.Now.ToString("yyyy/MM/dd");
            Boolean hasRows = false;

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM TestDetailsTBL WHERE LectNo = @param1 AND TestName = @param2";

                cmd.Parameters.AddWithValue("@param1", arrLectAcc[0]);
                cmd.Parameters.AddWithValue("@param2", testName);
                SqlDataReader sReader = cmd.ExecuteReader();

                hasRows = sReader.HasRows;

                //Close Connection
                conn.Close();
                cmd.Parameters.Clear();
                //Reopen the connection
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                if (hasRows)
                {
                    cmd.CommandText = @"UPDATE TestDetailsTBL SET NumQuestions = @param3, TestTotal = @param4, 
                                        DateCreated = @param5 WHERE LectNo = @param1 AND TestName = @param2"; 

                    cmd.Parameters.AddWithValue("@param1", LectNum);
                    cmd.Parameters.AddWithValue("@param2", testName);
                    cmd.Parameters.AddWithValue("@param3", arrTest.GetLength(0));
                    cmd.Parameters.AddWithValue("@param4", TotTestMarks);
                    cmd.Parameters.AddWithValue("@param5", DateCreated);

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText = @"INSERT INTO TestDetailsTBL(LectNo, TestName, LectName, NumQuestions, TestTotal, DateCreated) 
                                        VALUES(@param1, @param2, @param3, @param4, @param5, @param6)";

                    cmd.Parameters.AddWithValue("@param1", LectNum);
                    cmd.Parameters.AddWithValue("@param2", testName);
                    cmd.Parameters.AddWithValue("@param3", arrLectAcc[1]);
                    cmd.Parameters.AddWithValue("@param4", arrTest.GetLength(0));
                    cmd.Parameters.AddWithValue("@param5", TotTestMarks);
                    cmd.Parameters.AddWithValue("@param6", DateCreated);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Adding to the database failed");
            }

            cmd.Parameters.Clear();
            conn.Close();
        }

//--------------------------------------------------------------------------------------------------
        // Student

        public void RegisterStudent(String StudNum, String StudFName, String StudSName, String StudPass, String LastLoggedIn)
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"INSERT INTO StudentTBL(StudNo, StudFName, StudSName, StudPass, StudLastLoggedIn) 
                              VALUES(@param1, @param2, @param3, @param4, @param5)";

                cmd.Parameters.AddWithValue("@param1", StudNum);
                cmd.Parameters.AddWithValue("@param2", StudFName);
                cmd.Parameters.AddWithValue("@param3", StudSName);
                cmd.Parameters.AddWithValue("@param4", StudPass);
                cmd.Parameters.AddWithValue("@param5", LastLoggedIn);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Inserting to the database failed");
            }

            cmd.Parameters.Clear();
            conn.Close();
        }

        public bool isStudentExist(String StudNum)
        {
            this.StudNum = StudNum;
            bool Flag = false;

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT StudNo FROM StudentTBL WHERE StudNo = @param1";
                cmd.Parameters.AddWithValue("@param1", StudNum);
                SqlDataReader sReader = cmd.ExecuteReader();

                if (sReader.HasRows)
                {
                    Flag = true;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();
            return Flag;
        }

        public bool isStudentPassCorrect(String StudPass)
        {
            bool Flag = false;

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT * FROM StudentTBL WHERE StudNo = @param1 AND StudPass = @param2";

                cmd.Parameters.AddWithValue("@param1", StudNum);
                cmd.Parameters.AddWithValue("@param2", StudPass);
                SqlDataReader sReader = cmd.ExecuteReader();

                if (sReader.HasRows)
                {
                    Flag = true;
                    StudLstLogDate = DateTime.Now.ToString("dddd, dd MMMM yyyy hh:mm:ss tt");

                    while (sReader.Read())
                    {
                        sReader.GetValues(arrStudAcc);
                    }

                    cmd.Parameters.Clear();
                    conn.Close();
                    setStudLstLogInDate();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();
            return Flag;
        }

        public string getStudNum()
        {
            return arrStudAcc[0];
        }

        public string getStudFName()
        {
            return arrStudAcc[1];
        }

        public string getStudSName()
        {
            return arrStudAcc[2];
        }

        public string getStudPass()
        {
            return arrStudAcc[3];
        }

        public string getStudLstLogDate()
        {
            return arrStudAcc[4];
        }

        public void setStudLstLogInDate()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"UPDATE StudentTBL SET StudLastLoggedIn = @param1 WHERE StudNo = @param2";

                cmd.Parameters.AddWithValue("@param1", StudLstLogDate);
                cmd.Parameters.AddWithValue("@param2", arrStudAcc[0]);

                cmd.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Updating database failed");
            }
        }

        public void deleteStudAcc()
        {
            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"DELETE FROM StudentTBL WHERE StudNo = @param1";
                cmd.CommandText = @"DELETE FROM StudResultsTBL WHERE StudNo = @param1";

                cmd.Parameters.AddWithValue("@param1", arrStudAcc[0]);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Deleting data from database failed");
            }

            cmd.Parameters.Clear();
            conn.Close();
        }

        public string[][] getStudTestsContent()
        {
            string[][] readRows = new string[1][];

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT LectNo, LectName, TestName, NumQuestions, TestTotal, DateCreated
                                    FROM TestDetailsTBL";

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int rowLenght = dt.Rows.Count;
                readRows = new string[rowLenght][];
                int counter = 0;
                TotTestMarks = 0;

                foreach (DataRow rows in dt.Rows)
                {
                    readRows[counter] = new string[6];

                    for (int i = 0; i < 6; i++)
                    {
                        readRows[counter][i] = rows[i] + "";
                    }
                    counter++;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();
            return readRows;
        }

        public void setStudTestID(String LectNum, String testName, String SelTestCont)
        {
            this.LectNum = LectNum;
            this.testName = testName;
            this.SelTestCont = SelTestCont;
        }

        public string getSelTestCont()
        {
            return SelTestCont;
        }

        public string[][] readStudTest()
        {
            string[][] readRows = new string[1][];

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT Question, Option1, Option2, Option3, Option4, Answer, Marks
                                    FROM QuestionsTBL WHERE LectNo = @param1 AND TestName = @param2";

                cmd.Parameters.AddWithValue("@param1", LectNum);
                cmd.Parameters.AddWithValue("@param2", testName);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int rowLenght = dt.Rows.Count;
                readRows = new string[rowLenght][];
                arrTestMarks = new int[rowLenght];

                int counter = 0;
                TotTestMarks = 0;

                foreach (DataRow rows in dt.Rows)
                {
                    readRows[counter] = new string[7];

                    for (int i = 0; i < 7; i++)
                    {
                        readRows[counter][i] = rows[i] + "";
                    }

                    arrTestMarks[counter] = int.Parse(rows[6] + "");
                    counter++;
                }

                numQues = counter;
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();
            return readRows;
        }

        public int getNumQues()
        {
            return numQues;
        }

        public int[] getTestMarks()
        {
            return arrTestMarks;
        }

        public void saveStdResults(String stdResults)
        {
            Boolean hasRows = false;

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = "SELECT * FROM StudResultsTBL WHERE StudNo = @param1 AND TestName = @param2";

                cmd.Parameters.AddWithValue("@param1", arrStudAcc[0]);
                cmd.Parameters.AddWithValue("@param2", testName);
                SqlDataReader sReader = cmd.ExecuteReader();

                String[] splitRes = stdResults.Split('#');
                hasRows = sReader.HasRows;

                //Close Connection
                conn.Close();
                cmd.Parameters.Clear();
                //Reopen the connection
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                if (hasRows)
                {
                    cmd.CommandText = @"UPDATE StudResultsTBL SET StudMark = @param3, StudPercentage = @param4, 
                                        StudResult = @param5 WHERE StudNo = @param1 AND TestName = @param2";

                    cmd.Parameters.AddWithValue("@param1", arrStudAcc[0]);
                    cmd.Parameters.AddWithValue("@param2", testName);
                    cmd.Parameters.AddWithValue("@param3", splitRes[3]);
                    cmd.Parameters.AddWithValue("@param4", splitRes[4]);
                    cmd.Parameters.AddWithValue("@param5", splitRes[5]);

                    cmd.ExecuteNonQuery();
                }
                else
                {
                    cmd.CommandText = @"INSERT INTO StudResultsTBL(StudNo, LectNo, TestName, StudMark, StudPercentage, StudResult) 
                                        VALUES(@param1, @param2, @param3, @param4, @param5, @param6)";

                    cmd.Parameters.AddWithValue("@param1", arrStudAcc[0]);
                    cmd.Parameters.AddWithValue("@param2", splitRes[1]);
                    cmd.Parameters.AddWithValue("@param3", testName);
                    cmd.Parameters.AddWithValue("@param4", splitRes[3]);
                    cmd.Parameters.AddWithValue("@param5", splitRes[4]);
                    cmd.Parameters.AddWithValue("@param6", splitRes[5]);

                    cmd.ExecuteNonQuery();
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Adding to the database failed");
            }

            cmd.Parameters.Clear();
            conn.Close();
        }

        public String[][] readStdRes()
        {
            string[][] readRows = new string[1][];

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT TestDetailsTBL.LectName, StudResultsTBL.TestName, StudResultsTBL.StudMark, 
                                    TestDetailsTBL.TestTotal, StudResultsTBL.StudPercentage, StudResultsTBL.StudResult
                                    FROM StudResultsTBL INNER JOIN TestDetailsTBL ON StudResultsTBL.LectNo = TestDetailsTBL.LectNo
                                    AND StudResultsTBL.TestName = TestDetailsTBL.TestName
                                    WHERE StudResultsTBL.StudNo = @param1";

                cmd.Parameters.AddWithValue("@param1", arrStudAcc[0]);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int rowLenght = dt.Rows.Count;
                readRows = new string[rowLenght][];
                int counter = 0;

                foreach (DataRow rows in dt.Rows)
                {
                    readRows[counter] = new string[6];

                    for (int i = 0; i < 6; i++)
                    {
                        readRows[counter][i] = rows[i] + "";
                    }
                    counter++;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();
            return readRows;
        }

        public string[] getAllTests()
        {
            List<String> listTestNames = new List<string>();

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT TestName FROM TestDetailsTBL WHERE LectNo = @param1";
                cmd.Parameters.AddWithValue("@param1", LectNum);
                SqlDataReader sReader = cmd.ExecuteReader();

                while (sReader.Read())
                {
                    listTestNames.Add(sReader.GetSqlString(0).ToString());
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();

            return listTestNames.ToArray();
        }

        public string[][] readAllStudRes(String testName)
        {
            string[][] readRows = new string[1][];

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT StudentTBL.StudNo, StudentTBL.StudFName, StudentTBL.StudSName,
                                    StudResultsTBL.TestName, StudResultsTBL.StudPercentage, StudResultsTBL.StudResult
                                    FROM StudentTBL LEFT JOIN StudResultsTBL ON StudentTBL.StudNo = StudResultsTBL.StudNo
                                    WHERE StudResultsTBL.TestName = @param1";

                cmd.Parameters.AddWithValue("@param1", testName);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                int rowLenght = dt.Rows.Count;
                readRows = new string[rowLenght][];
                int counter = 0;

                foreach (DataRow rows in dt.Rows)
                {
                    readRows[counter] = new string[6];

                    for (int i = 0; i < 6; i++)
                    {
                        readRows[counter][i] = rows[i] + "";
                    }
                    counter++;
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();
            return readRows;
        }

        public string[] calAllStudRes(String testName)
        {
            string[] readRow = new string[4];

            try
            {
                conn.Open();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.Text;

                cmd.CommandText = @"SELECT COUNT(*), AVG(StudPercentage), MAX(StudPercentage), MIN(StudPercentage)
                                    FROM StudResultsTBL WHERE TestName = @param1";

                cmd.Parameters.AddWithValue("@param1", testName);

                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        readRow[i] = row[i] + "";
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message.ToString(), "Database Error");
            }

            cmd.Parameters.Clear();
            conn.Close();
            return readRow;
        }
    }
}
