using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace Patterns.Creational.Build
{
	public class PeopleCreatorUI : MonoBehaviour
	{
		[Header("Config")]
		[SerializeField] private TMP_InputField name_InputField;
		[SerializeField] private TMP_InputField surname_InputField;
		[SerializeField] private TMP_InputField age_InputField;

		[SerializeField] private GameObject peopleLabelText_prefab;
		[SerializeField] private Transform peopleList;

		private readonly PeopleBuilder _peopleBuilder = new PeopleBuilder();

		public void CreatePeople()
        {
			People people = _peopleBuilder
				.WithName(name_InputField.text)
				.WithSurname(surname_InputField.text)
				.WithAge(int.Parse(age_InputField.text));

			GameObject peopleLabel = Instantiate(peopleLabelText_prefab, peopleList);
			peopleLabel.GetComponent<TextMeshProUGUI>().text = people.ToText();
        }
	}
}