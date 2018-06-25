namespace Zoo
{
    internal abstract class Animal
    {
        private string name;
        private int age;
        private string gender;
        private int fedTimes;

        public Animal(string name)
        {
            this.Name = name;
            age = 0;
            gender = "";
        }

        public Animal(string name, int age, string gender)
        {
            this.Name = name;
            this.age = age;
            this.gender = gender;
        }

        public string Name { get => name; set => name = value; }

        public void Eat()
        {
            fedTimes++;
        }

        public abstract bool isHungry();

        public override string ToString()
        {
            return Name + " is a " + age + "years old" + gender + " animal and was fed " + fedTimes+  "times";
        }
    }
}