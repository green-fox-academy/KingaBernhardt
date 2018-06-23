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
            this.name = name;
            age = 0;
            gender = "";
        }

        public Animal(string name, int age, string gender)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
        }

        public void Eat()
        {
            fedTimes++;
        }

        public abstract bool isHungry();

        public override string ToString()
        {
            return name + " is a " + age + "years old" + gender + " animal and was fed " + fedTimes+  "times";
        }
        public void GetRange()
        {

        }

    }
}