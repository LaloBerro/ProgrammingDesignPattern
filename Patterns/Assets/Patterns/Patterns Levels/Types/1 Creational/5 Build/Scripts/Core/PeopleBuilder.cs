namespace Patterns.Creational.Build
{
	public class PeopleBuilder
	{
		private string _peopleName;
		private string _surName;

		private int _age;

		public PeopleBuilder WithName(string name)
        {
			_peopleName = name;
			return this;
        }

		public PeopleBuilder WithSurname(string surname)
		{
			_surName = surname;
			return this;
		}

		public PeopleBuilder WithAge(int age)
		{
			_age = age;
			return this;
		}

		public People Build()
        {
			return new People(_peopleName, _surName, _age);
        }

		public static implicit operator People(PeopleBuilder peopleBuilder)
        {
			return peopleBuilder.Build();
        }
	}
}