using System;
using System.Collections.Generic;

public class Contact
{
  long phno;
  string name;
    Contact ()
  {
  }

  public Contact (string nam, long phn)
  {
    phno = phn;
    name = nam;
  }

  public override string ToString ()
  {
    return name + " " + phno;
  }
}

class main
{
  public static void Main ()
  {

    List < Contact > contacts = new List < Contact > ();

    string inp = "";
    string name="";
    long phone = 0000000000000;

    while (inp != "5")
      {
	Console.
	  WriteLine
	  ("Menu:\n1. Add Contact\n2. Display Contact\n3. Delete Contact\n4. Show All Contacts\n5. Exit\n");

	inp = Console.ReadLine ();
	switch (inp)
	  {
	  case "1":
    	    Console.WriteLine ("Enter Name and phonenumber:");
    	    name = Console.ReadLine ();
    	    phone = long.Parse(Console.ReadLine ());
    	    Contact c = new Contact (name,phone);
	        contacts.Add (c);
	        break;
	    case "2":Console.WriteLine (name + " " + phone);
	        break;
	    case "3":Console.WriteLine ("");
	        break;
	    case "4":Console.WriteLine("----------------Showing All Contacts---------------");
	            for (int i = 0; i < contacts.Count; i++)
        	      {
        		    Console.WriteLine (contacts[i]);
        	      }
	            break;
	  case "5":
	    Console.WriteLine ("Quitting");
	    break;
	  default:
	    Console.WriteLine ("Enter another options");
	    break;
	  }
      }
  }

}
