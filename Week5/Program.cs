//AND (&&) a and OR (||) logical operators

//AND
//true && true => true
//true && false => false
//false && true => false
//false && false => true
//while (true) {                    //I added a while loop that I don`t have to reload everytime while testing the AND 

//    string username, password; //username: admin //password: admin1234

//    Console.WriteLine("Enter username:");
//    username = Console.ReadLine();

//    Console.WriteLine("Enter password:");
//    password = Console.ReadLine();

//    if (username == "admin" && password == "admin1234")
//    {
//        Console.WriteLine("Welcome!");
//        break;
//    }

//    else
//    {
//        Console.WriteLine("Invalid user credentials! Try again:");
//    }

//}



//OR
//true || true => true
//true || false => true
//false || true => true
//false || false => false

using System.ComponentModel.Design;

string username, password; //username: admin //password: admin1234


while (true)                        //I added a while loop that I don`t have to reload everytime while testing the OR       
{

    Console.WriteLine("Enter username:");
username = Console.ReadLine();

Console.WriteLine("Enter password:");
password = Console.ReadLine();


    if (username != "admin" || password != "admin1234") //!= means not equal!
    {
        Console.WriteLine("Invalid users credentials");
        
    }
    else
    {
        Console.WriteLine("Welcome!");
        break;
    }
}