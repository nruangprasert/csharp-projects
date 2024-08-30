using System;
namespace TicketRecorder
{
    internal class Ticket
    {
        private const double COST_PER_5_OVER = 87.50;
        private string studentNumber;
        private char classif;
        private int speedLimit;
        private int speedTraveling;
        public Ticket() 
        {
        }
        public Ticket(string studentNumber, char classif, int speedLimit, int speedTraveling)
        {
            this.studentNumber = studentNumber;
            this.classif = classif;
            this.speedLimit = speedLimit;
            this.speedTraveling = speedTraveling;
        }
        public string StudentNumber 
        {
            get { return studentNumber; }
            set { studentNumber = value; }
        }
        public char Classif 
        {
            get { return classif; }
            set { classif = value; }
        }
        public int SpeedLimit 
        {
            get { return speedLimit; }
            set { speedLimit = value; }
        }
        public int SpeedTravelling 
        {
            get { return speedTraveling; }
            set { speedTraveling = value; }
        }
        public double CalculateFine()
        {
            int milesOverSpeedLimit = speedTraveling - speedLimit;
            double fine;
            fine = (double) (milesOverSpeedLimit / 5 * COST_PER_5_OVER) + 75.00;
            if (classif == '4')
                if (milesOverSpeedLimit > 20)
                    fine += 200;
                else
                    fine += 50;
            else
            if (classif == '1')
                if (milesOverSpeedLimit < 20)
                    fine -= 50;
                else
                fine += 100;
            else
            if (milesOverSpeedLimit > 19)
                fine += 100;
            return fine;
        }
        public string ReturnNameOfClassification()
        {
            string classificationName;
            switch (classif)
            {
                case '1':
                    classificationName = "Freshman";
                    break;
                case '2':
                    classificationName = "Sophomore";
                    break;
                case '3':
                    classificationName = "Junior";
                    break;
                case '4':
                    classificationName = "Senior";
                    break;
                default:
                    classificationName = "Unspecified";
                    break;
            }
            return classificationName;
        }
        public override string ToString()
        {
            return "\tTicket App" +
            "\n\nStudent number: " + studentNumber +
            "\nClassification: " + ReturnNameOfClassification() +
            "\nSpeed limit: " + speedLimit +
            "\nReported speed: " + speedTraveling +
            "\n\nFine: " + CalculateFine().ToString("C2");
        }
    }
}