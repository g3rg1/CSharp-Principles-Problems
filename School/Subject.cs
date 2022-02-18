namespace School
{
    class Subject
    {
        private string name = null;
        private int totalHours = 0;
        private int exerciseCount = 0;

        public Subject(string name, int totalHours, int exerciseCount)
        {
            name = this.name;
            totalHours = this.totalHours;
            exerciseCount = this.exerciseCount;
        }

        public string Name
        {
            get => name;
            set => name = value;
        }
        public int TotalHours
        {
            get => totalHours;
            set => totalHours = value;
        }
        private int ExerciseCount
        {
            get => exerciseCount;
            set => exerciseCount = value;
        }
    }
}
