using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyManagement
{
    internal class Assessment
    {
        internal String Term;
        private int assessmentId;
        private string assessmentName;
        private double achievedMark;
        private double fullMark;
        private string dueDate;
    
       

        public Assessment() { }

        public Assessment(int assessmentId, string assessmentName, double fullMark, string dueDate, double achievedMark)
        {
            this.assessmentId = assessmentId;
            this.assessmentName = assessmentName;
            this.fullMark = fullMark;
            this.dueDate = dueDate;
            this.achievedMark = achievedMark;


        }

        public int AssessmentId
        {
            get { return assessmentId; }
            set { assessmentId = value; }
        }

        public string AssessmentName
        {
            get { return assessmentName; }
            set { assessmentName = value; }
        }

        public double AchievedMark
        {
            get { return achievedMark; }
            set { achievedMark = value; }
        }

        public double FullMark
        {
            get { return fullMark; }
            set { fullMark = value; }
        }

        public string DueDate
        {
            get { return dueDate; }
            set { dueDate = value; }
        }

        
    }
}
