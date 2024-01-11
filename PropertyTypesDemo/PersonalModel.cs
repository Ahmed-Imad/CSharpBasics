
namespace PropertyTypesDemo;

public class PersonalModel
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }

	private int _age;

	public int Age
	{
		get 
		{ 
			return _age; 
		}
		set 
		{ 
			if (value >= 0 && value < 126) 
			{
				_age = value; 
			}
			else
			{
				throw new ArgumentOutOfRangeException(nameof(value), "Age need to be in valid range.");
			}
		}
	}
	private string? _ssn;

	public string SSN
	{
		get 
		{ 
			string output = "***-**-"+ _ssn?.Substring(_ssn.Length-4);
			return output; 
		}
		set 
		{
			_ssn = value;
		}
	}


}
