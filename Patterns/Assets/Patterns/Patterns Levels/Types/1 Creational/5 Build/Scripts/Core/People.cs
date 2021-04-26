namespace Patterns.Creational.Build
{
	public class People
	{
		public string name;
		public string surname;
		public int age;

        public People(string name, string surname, int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
        }

        public string ToText()
        {
            return $"{name} {surname} {age}";
        }
    }
}