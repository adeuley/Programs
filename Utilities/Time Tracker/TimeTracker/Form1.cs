using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TimeTracker.Properties;

namespace TimeTracker
{
    public partial class frmTimeTracker : Form
    {
        //Variables
        //Record Location
        string pathName = "C:\\TimeTrackerRecords";
        //Progress file name
        string dayProgress = "\\TrackerLogProgress.txt";

        //Variables for Totals
        string dayTotals = "\\TrackLogTotals.txt";
        string currentDate;
        List<DayTotals> allDays = new List<DayTotals>();
        private ProjectionInfo currentProject = new ProjectionInfo();
        public List<string> dateList = new List<string>();
        DayTotals dayList = new DayTotals();

        public frmTimeTracker()
        {
            InitializeComponent();
            currentDate = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
            
            System.IO.Directory.CreateDirectory(pathName);

            if (System.IO.File.Exists(pathName + dayProgress))
            {

                System.IO.StreamReader progressReader = new System.IO.StreamReader(pathName + dayProgress);
                string currentProgressDate = progressReader.ReadLine();
                progressReader.Close();
                if (currentProgressDate == currentDate)
                {

                    openDayProgress();
                }
                else
                {
                    System.IO.StreamWriter progressWriter = new System.IO.StreamWriter(pathName + dayProgress, false);
                    progressWriter.Write(currentDate);
                    progressWriter.Close();
                }

            }
            else
            {
                System.IO.StreamWriter progressWriter = new System.IO.StreamWriter(pathName + dayProgress, false);
                progressWriter.Write(currentDate);
                progressWriter.Close();
            }

            // readDayTotals();

        }

        //Buttons
        private void btnNewProject_Click(object sender, EventArgs e)
        {


            if (tBoxPjtNumber.Text  != "")
            {
                string projectNumber = tBoxPjtNumber.Text;
                string projectDiscipline = cBoxDiscipline.Text;
                string projectDescription = tBoxDescription.Text;
                addTime(projectNumber, projectDiscipline, projectDescription);
                currentProject.ProjectNumber = projectNumber;
                currentProject.projectDiscipline = projectDiscipline;
                currentProject.projectDescription = projectDescription;


                if (checked(chBoxCreateButton.Checked))
                {
                    addProject(projectNumber, projectDiscipline, projectDescription);
                }

                tBoxPjtNumber.Clear();
                tBoxDescription.Clear();
                chBoxCreateButton.Checked = true;

                lbl_CurrentInfo.Text = currentProject.ProjectNumber + " - " + currentProject.projectDiscipline + " - " + currentProject.projectDescription;
            }
        }
        private void btnAssistDesigner_Click(object sender, EventArgs e)
        {
            addTime("TSG1000.01", "Other", "Assist Designer");
            lbl_CurrentInfo.Text = "TSG1000.01 - Other - Assist Designer";
            currentProject.ProjectNumber = "TSG1000.01";
            currentProject.projectDiscipline = "Other";
            currentProject.projectDescription = "Assist Designer";
        }
        private void btnAssistCAD_Click(object sender, EventArgs e)
        {
            addTime("TSG1000.01", "Other", "Assist CAD");
            lbl_CurrentInfo.Text = "TSG1000.01 - Other - Assist CAD";
            currentProject.ProjectNumber = "TSG1000.01";
            currentProject.projectDiscipline = "Other";
            currentProject.projectDescription = "Assist CAD";
        }
        private void btnAssistPM_Click(object sender, EventArgs e)
        {
            addTime("TSG1000.01", "Other", "Assist PM");
            lbl_CurrentInfo.Text = "TSG1000.01 - Other - Assist PM";
            currentProject.ProjectNumber = "TSG1000.01";
            currentProject.projectDiscipline = "Other";
            currentProject.projectDescription = "Assist PM";
        }
        private void btnMisc_Click(object sender, EventArgs e)
        {
            addTime("TSG1000.01", "Other", "Miscelleneous");
            lbl_CurrentInfo.Text = "TSG1000.01 - Other - Miscelleneous";
            currentProject.ProjectNumber = "TSG1000.01";
            currentProject.projectDiscipline = "Other";
            currentProject.projectDescription = "Miscelleneous";
        }
        private void btnLunch_Click(object sender, EventArgs e)
        {
            addTime("Lunch", "Other", "Lunch");
            lbl_CurrentInfo.Text = "Lunch - Other - Lunch";
            currentProject.ProjectNumber = "Lunch";
            currentProject.projectDiscipline = "Other";
            currentProject.projectDescription = "Lunch";
        }
        private void btnFinished_Click(object sender, EventArgs e)
        {
            if (dGViewTotals.Rows.Count > 1)
            {
                //Add finish time to row current row and calculate total time
                DataGridViewRow lRow = dGViewTotals.Rows[dGViewTotals.Rows.Count - 2];
                int tNowHrs = DateTime.Now.Hour;
                int tNowMin = DateTime.Now.Minute;
                double tNowMinDouble = tNowMin / 60.0;
                string nowTime = tNowHrs.ToString("00") + ":" + tNowMin.ToString("00");
                lRow.Cells[2].Value = nowTime;

                string stHours = lRow.Cells[1].Value.ToString().Substring(0, 2);
                string stMins = lRow.Cells[1].Value.ToString().Substring(3, 2);
                double stTime = Convert.ToDouble(stHours) + Math.Round(Convert.ToDouble(stMins) / 60, 2);
                double edTime = Math.Round(tNowHrs + tNowMinDouble, 2);
                double totalTime = Math.Abs(Math.Round(edTime - stTime, 2));
                string stringTotalTime = totalTime.ToString("00.00");
            
                lRow.Cells[3].Value = stringTotalTime;

                totalTimes(currentProject.ProjectNumber, currentProject.projectDiscipline, currentProject.projectDescription, stringTotalTime);

                exportTimes();

                //Round Total Times
                foreach (DataGridViewRow row in dgvTotals.Rows)
                {
                    if (row.Index != dgvTotals.Rows.Count - 1)
                    {
                        string currentTime = row.Cells[3].Value.ToString();
                        string currentHours = currentTime.Substring(0, 2);
                        int intHours = Convert.ToInt32(currentHours);
                        string currentMinutes = currentTime.Substring(3, 2);
                        int intMinutes = Convert.ToInt32(currentMinutes);

                        if (intMinutes <= 12)
                        {
                            currentMinutes = "00";
                        }
                        else if (intMinutes > 12 & intMinutes <= 34)
                        {
                            currentMinutes = "25";
                        }
                        else if (intMinutes > 34 & intMinutes <= 62)
                        {
                            currentMinutes = "50";
                        }
                        else if (intMinutes > 62 & intMinutes <= 88)
                        {
                            currentMinutes = "75";
                        }
                        else if (intMinutes > 88)
                        {
                            intHours = intHours + 1;
                            currentHours = intHours.ToString("00");
                            currentMinutes = "00";
                        }

                        string currentTotalTime = currentHours + "." + currentMinutes;
                        row.Cells[3].Value = currentTotalTime;
                    }
                }
               
                    exportTotalTimes();
              
               
                tabControl1.SelectTab(2);
            }
        }
        private void dgvProjectList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (dgvProjectList.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    addTime(dgvProjectList.Rows[e.RowIndex].Cells[0].Value.ToString(), dgvProjectList.Rows[e.RowIndex].Cells[1].Value.ToString(), dgvProjectList.Rows[e.RowIndex].Cells[2].Value.ToString());
                    currentProject.ProjectNumber = dgvProjectList.Rows[e.RowIndex].Cells[0].Value.ToString();
                    currentProject.projectDiscipline = dgvProjectList.Rows[e.RowIndex].Cells[1].Value.ToString();
                    currentProject.projectDescription = dgvProjectList.Rows[e.RowIndex].Cells[2].Value.ToString();

                    lbl_CurrentInfo.Text = currentProject.ProjectNumber + " - " + currentProject.projectDiscipline + " - " + currentProject.projectDescription;
                }
            }
            else if (e.ColumnIndex == 3)
            {
                if (dgvProjectList.Rows[e.RowIndex].Cells[0].Value != null)
                {
                    DataGridViewRow dRow = dgvProjectList.Rows[e.RowIndex];
                    dgvProjectList.Rows.Remove(dRow);
                }
            }


        }
        private void btnNewDay_Click(object sender, EventArgs e)
        {
            dGViewTotals.Rows.Clear();
            dgvProjectList.Rows.Clear();
            dgvTotals.Rows.Clear();
            lbl_CurrentInfo.Text = "";
            tBoxPjtNumber.Clear();
            tBoxDescription.Clear();
          

        }
        private void btnAddOnly_Click(object sender, EventArgs e)
        {
            string projectNumber = tBoxPjtNumber.Text;
            string projectDiscipline = cBoxDiscipline.Text;
            string projectDescription = tBoxDescription.Text;
            addProject(projectNumber, projectDiscipline, projectDescription);
            tBoxPjtNumber.Clear();
            tBoxDescription.Clear();

        }
        private void btnRecordsOpen_Click(object sender, EventArgs e)
        {
            dGViewRecords.Rows.Clear();
            openDayTotals();
        }

        //Methods
        public void exportTimes()
        {

            System.IO.StreamWriter objWriter = new System.IO.StreamWriter(pathName + dayProgress, false);

            objWriter.WriteLine(currentDate);

            foreach (DataGridViewRow row in dGViewTotals.Rows)
            {
                String dayProgressText = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.ColumnIndex == 0)
                    {
                        dayProgressText += cell.Value;
                    }
                    else
                    {
                        dayProgressText += "\t" + cell.Value;
                    }
                }
                objWriter.WriteLine(dayProgressText);
            }

            objWriter.Close();
        }
        public void totalTimes(string iProjectNumber, string iProjectDiscipline, string iProjectDescription, string iTotalTime)
        {

            int rowIndex = -1;
            foreach (DataGridViewRow row in dgvTotals.Rows)
            {
                if (row.Cells[0].Value == iProjectNumber & row.Cells[1].Value == iProjectDiscipline)
                {
                    rowIndex = row.Index;
                }

            }
            if (rowIndex == -1)
            {
                if (dgvTotals.Rows.Count == 1)
                {
                    DataGridViewRow dRow;
                    dRow = (DataGridViewRow)dgvTotals.Rows[0].Clone();
                    dRow.Cells[0].Value = iProjectNumber;
                    dRow.Cells[1].Value = iProjectDiscipline;
                    dRow.Cells[2].Value = iProjectDescription;
                    dRow.Cells[3].Value = iTotalTime;
                    dgvTotals.Rows.Add(dRow);
                }
                else
                {
                    DataGridViewRow dRow;
                    dRow = (DataGridViewRow)dgvTotals.Rows[dgvTotals.Rows.Count - 1].Clone();
                    dRow.Cells[0].Value = iProjectNumber;
                    dRow.Cells[1].Value = iProjectDiscipline;
                    dRow.Cells[2].Value = iProjectDescription;
                    dRow.Cells[3].Value = iTotalTime;
                    dgvTotals.Rows.Add(dRow);
                }
            }
            else
            {
                //Add Times
                double calculatedTime = Convert.ToDouble(dgvTotals.Rows[rowIndex].Cells[3].Value.ToString()) + Convert.ToDouble(iTotalTime);
                dgvTotals.Rows[rowIndex].Cells[3].Value = calculatedTime.ToString("00.00");
                //Add Description
                if (dgvTotals.Rows[rowIndex].Cells[2].Value.ToString().Contains(iProjectDescription))
                {
                }
                else
                {
                    iProjectDescription = dgvTotals.Rows[rowIndex].Cells[2].Value.ToString() + "," + iProjectDescription;
                    dgvTotals.Rows[rowIndex].Cells[2].Value = iProjectDescription;
                }

            }



        }
        public void addProject(string pNumber, string pDiscipline, string pDescription)
        {

            DataGridViewRow dRow;
            if (dgvProjectList.Rows.Count == 1)
            {
                dRow = (DataGridViewRow)dgvProjectList.Rows[0].Clone();

            }
            else
            {
                dRow = (DataGridViewRow)dgvProjectList.Rows[dgvProjectList.Rows.Count - 1].Clone();

            }
            dRow.Cells[0].Value = pNumber;
            dRow.Cells[1].Value = pDiscipline;
            dRow.Cells[2].Value = pDescription;
            dgvProjectList.Rows.Add(dRow);
        }
        public void addTime(string pNumber, string pDiscipline, string pDescription)
        {
            String testDate = DateTime.Now.Year + "-" + DateTime.Now.Month + "-" + DateTime.Now.Day;
          
            if (dGViewTotals.Rows.Count == 1)
            {

                DataGridViewRow dRow = (DataGridViewRow)dGViewTotals.Rows[0].Clone();
                dRow.Cells[0].Value = pNumber;
                int tHrs = DateTime.Now.Hour;

                int tMin = DateTime.Now.Minute;
                string nowTime;
                
                    if (tHrs < 10)
                    {
                        nowTime = "0" + tHrs;
                    }
                    else
                    {
                        nowTime = Convert.ToString(tHrs);
                    }

                    if (tMin < 10)
                    {
                        nowTime = nowTime + ":0" + tMin;
                    }
                    else
                    {
                        nowTime = nowTime + ":" + tMin;
                    }
                
               
                dRow.Cells[1].Value = nowTime;
                dRow.Cells[4].Value = pDiscipline;
                dRow.Cells[5].Value = pDescription;
                dGViewTotals.Rows.Add(dRow);
            }
            else
            {
                //Add finish time to row current row and calculate total time
                DataGridViewRow lRow = dGViewTotals.Rows[dGViewTotals.Rows.Count - 2];

                if (lRow.Cells[2].Value == null)
                {
                    int tNowHrs = DateTime.Now.Hour;
                    int tNowMin = DateTime.Now.Minute;
                    string nowTime;
                    if (testDate == currentDate)
                    {
                        if (tNowHrs < 10)
                        {
                            nowTime = "0" + tNowHrs;
                        }
                        else
                        {
                            nowTime = Convert.ToString(tNowHrs);
                        }

                        if (tNowMin < 10)
                        {
                            nowTime = nowTime + ":0" + tNowMin;
                        }
                        else
                        {
                            nowTime = nowTime + ":" + tNowMin;
                        }

                    }
                    else
                    {
                        nowTime = "23:59";
                    }
                         lRow.Cells[2].Value = nowTime;

                    //Calculated Total Time
                    string stHours = lRow.Cells[1].Value.ToString().Substring(0, 2);
                    string stMins = lRow.Cells[1].Value.ToString().Substring(3, 2);

                    double stTime = Convert.ToDouble(stHours) + Math.Round(Convert.ToDouble(stMins) / 60, 2);

                    double edTime = tNowHrs + Math.Round(tNowMin / 60.0, 2);

                    double totalTime = Math.Round(edTime - stTime, 2);
                    string stringTotalTime = totalTime.ToString("00.00");
                    lRow.Cells[3].Value = stringTotalTime;
                    totalTimes(currentProject.ProjectNumber, currentProject.projectDiscipline, currentProject.projectDescription, stringTotalTime);
                }
                //Add New row
                // DataGridViewRow dRow = dGViewTotals.Rows.Add(1);
                DataGridViewRow dRow = (DataGridViewRow)dGViewTotals.Rows[dGViewTotals.Rows.Count - 1].Clone();
                dRow.Cells[0].Value = pNumber;
                int tHrs = DateTime.Now.Hour;
                int tMin = DateTime.Now.Minute;
                string newTime;

                if (tHrs < 10)
                {
                    newTime = "0" + tHrs;
                }
                else
                {
                    newTime = Convert.ToString(tHrs);
                }

                if (tMin < 10)
                {
                    newTime = newTime + ":0" + tMin;
                }
                else
                {
                    newTime = newTime + ":" + tMin;
                }
                dRow.Cells[1].Value = newTime;
                dRow.Cells[4].Value = pDiscipline;
                dRow.Cells[5].Value = pDescription;
                dGViewTotals.Rows.Add(dRow);



                exportTimes();


            }


        }
        public void openDayProgress()
        {

            if (System.IO.File.Exists(pathName + dayProgress))
            {

                System.IO.StreamReader progressReader = new System.IO.StreamReader(pathName + dayProgress);
                progressReader.ReadLine();
                while (progressReader.Peek() > 0)
                {
                    var line = progressReader.ReadLine().Split('\t');
                    if (dGViewTotals.Rows.Count == 1)
                    {

                        DataGridViewRow dRow = (DataGridViewRow)dGViewTotals.Rows[0].Clone();
                        dRow.Cells[0].Value = line[0];
                        dRow.Cells[1].Value = line[1];
                        dRow.Cells[2].Value = line[2];
                        dRow.Cells[3].Value = line[3];
                        dRow.Cells[4].Value = line[4];
                        dRow.Cells[5].Value = line[5];
                        dGViewTotals.Rows.Add(dRow);
                    }
                    else
                    {
                        DataGridViewRow dRow = (DataGridViewRow)dGViewTotals.Rows[dGViewTotals.Rows.Count - 1].Clone();

                        dRow.Cells[0].Value = line[0];
                        dRow.Cells[1].Value = line[1];
                        dRow.Cells[2].Value = line[2];
                        dRow.Cells[3].Value = line[3];
                        dRow.Cells[4].Value = line[4];
                        dRow.Cells[5].Value = line[5];
                        dGViewTotals.Rows.Add(dRow);
                    }

                }
                progressReader.Close();
            }
        }
        public void openDayTotals()
        {
            string selectedDate = comboBoxRecords.SelectedItem.ToString();

            foreach (DayTotals d in allDays)
            {

                if (d.date == selectedDate)
                {


                    foreach (ProjectTotals p in d.projects)
                    {



                        DataGridViewRow dRow;
                        if (dGViewRecords.Rows.Count == 1)
                        {
                            dRow = (DataGridViewRow)dGViewRecords.Rows[0].Clone();

                        }
                        else
                        {
                            dRow = (DataGridViewRow)dGViewRecords.Rows[dGViewRecords.Rows.Count - 1].Clone();

                        }
                        dRow.Cells[0].Value = p.projectNumber;
                        dRow.Cells[1].Value = p.projectDiscipline;
                        dRow.Cells[2].Value = p.projectDescription;
                        dRow.Cells[3].Value = p.totalTime;
                        dGViewRecords.Rows.Add(dRow);
                    }

                }

            }
        }
        public void readDayTotals()
        {
            if (System.IO.File.Exists(pathName + dayTotals))
            {

                System.IO.StreamReader totalsReader = new System.IO.StreamReader(pathName + dayTotals);
                string newDate = "";

                int test = 0;

               // totalsReader.Read();

                while (totalsReader.Peek() >= 0)
                {



                    string[] line = totalsReader.ReadLine().Split('\t');


                    if (test == 0)
                    {
                        newDate = line[0];
                        dayList.date = newDate;
                        dateList.Add(newDate);
                        test = 1;
                    }



                    if (newDate != line[0])
                    {

                        allDays.Add(dayList);
                        dateList.Add(line[0]);
                        dayList = new DayTotals();
                        newDate = line[0];
                        dayList.date = newDate;
                    }



                    ProjectTotals dayProjectTotal = new ProjectTotals(line[1], line[2], line[3], line[4]);

                    dayList.projects.Add(dayProjectTotal);
                }
                allDays.Add(dayList);

                totalsReader.Close();
                this.comboBoxRecords.DataSource = dateList;

            }
        }
        public void removeDayTotals()
        {

        }
        public void exportTotalTimes()
        {
           
            System.IO.StreamWriter objWriter = new System.IO.StreamWriter(pathName + dayTotals, true);
            //String dayTotalText = "";


            foreach (DataGridViewRow row in dgvTotals.Rows)
            {
                if (row.Index != dgvTotals.Rows.Count - 1)
                {
                    String dayTotalText = "";
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 0)
                        {
                            dayTotalText += currentDate + "\t" + cell.Value;
                        }
                        else
                        {
                            dayTotalText += "\t" + cell.Value;
                        }
                    }
                    objWriter.WriteLine(dayTotalText);
                }
            }

            objWriter.Close();
        }

        //Classes
        public class ProjectionInfo
        {
            private string m_ProjectNumber;
            private string m_ProjectDescription;
            private string m_ProjectDiscipline;

            public string ProjectNumber
            {
                get { return m_ProjectNumber; }
                set { m_ProjectNumber = value; }
            }
            public string projectDiscipline
            {
                get { return m_ProjectDiscipline; }
                set { m_ProjectDiscipline = value; }
            }
            public string projectDescription
            {
                get { return m_ProjectDescription; }
                set { m_ProjectDescription = value; }
            }


        }
        class DayTotals
        {
            private string m_Date;
            public List<ProjectTotals> projects = new List<ProjectTotals>();

            public string date
            {
                get { return m_Date; }
                set { m_Date = value; }
            }


        }
        public class ProjectTotals
        {
            //Variables
            private string m_PNumber;
            private string m_PDiscipline;
            private string m_PDescription;
            private string m_PTimeTotal;

            public ProjectTotals(string projectNumber, string projectDiscipline, string projectDescription, string totalTime)
            {
                m_PNumber = projectNumber;
                m_PDiscipline = projectDiscipline;
                m_PDescription = projectDescription;
                m_PTimeTotal = totalTime;
            }

            public string projectNumber
            {
                get { return m_PNumber; }
                set { m_PNumber = value; }
            }
            public string projectDiscipline
            {
                get { return m_PDiscipline; }
                set { m_PDiscipline = value; }
            }
            public string projectDescription
            {
                get { return m_PDescription; }
                set { m_PDescription = value; }
            }
            public string totalTime
            {
                get { return m_PTimeTotal; }
                set { m_PTimeTotal = value; }
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 3)
            {
                readDayTotals();
            }

        }

        private void frmTimeTracker_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = Location;
        }

        private void frmTimeTracker_Load(object sender, EventArgs e)
        {
            this.Location = Properties.Settings.Default.Location;
        }
        
    }


}


