// https://www.youtube.com/watch?v=9Byvwa9yF-I&ab_channel=IAmTimCorey


// Records are not VALUE type
// Its bit of encapsulation around Class and hence it is a REFERENCE type
// It has some pre-built code inside to make our life easy.


//Records are Immutable records by default ( Readonly class )
//Default implementation of ToString
public record Person(string FirstName,string LastName);

public class PersonClass
{
  public string FirstName { get; init; }
  public string LastName { get; init; }

  public PersonClass()
  {
    
  }

  public void DeConstruct(out string firstName,out string lastName)
  {
    firstName = FirstName;
    lastName = LastName;
  }
}

public class Animal 
{
  private int i;

  public int Age
  {
    get => i;
    init => i = value;
  }
}