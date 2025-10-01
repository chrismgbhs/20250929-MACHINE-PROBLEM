[MP1.txt](https://github.com/user-attachments/files/22635682/MP1.txt)
[20250929 [MP1.pdf](https://github.com/user-attachments/files/22635622/MP1.pdf)
[Uploading2.5. MP
BY MAGBUHOS, CHRIS BOEN I.
OUTPUT (ENCODE)

OUTPUT (DECODE)

1. The Main() Method

This is the main method, the starting point of the program. First, it will run the AssignChars() method to get the alphabet array. After that, it will get the key array after getting the pass phrase input of the user, and the characters array which has been established earlier. Afterwards, assigning it into an array with all of the unique combination of alphabet letters as key array. Additional methods will run such as the program method for encoding and decoding which will happen inside the RunProgram() method which requires running the DetermineMode() method which will determine the mode the user wants to pursue, and the key and characters array which has been established earlier will also be used. All of which are essential for this method.

2. AssignChars() Method

The AssignChars() Method assigns the alphabet characters into the arr array. The alphabet characters are determined using the ASCII codes of each letters (65-90).  After assigning the letters to the arr array, it will return the array as the value of this method.
3. GetPassPhrase() Method

The GetPassPhrase() method prompts the user to enter its pass phrase. This pass phrase will be used to establish the key later. After getting the pass phrase, the method will return the pass phrase as its value.

4. AssignPassPhrase() Method

The AssignPassPhrase() assigns the characters in the pass phrase to the key array. It will reiterate through each of the characters in the pass phrase, and counting of the character of the pass phrase that is being passed is essential. Additionally, there are conditions that need to be met before passing it to the array.  First, the character of the pass phrase that will be passed must a be a new character inside the key array to prevent duplication. Second, the character of the pass phrase which will be passed must be an alphabet character, must not be a special character or a whitespace. If these conditions are met, the pass phrase character will be added to the key array. The passing of characters will happen until the last character of the pass phrase was checked.
5. DetermineMode() Method

The DetermineMode() method prompts the user to enter its program mode that they want to pursue. The program will return the corresponding value of the input as its value if the input equates to �encode� or �decode�.
6. RunProgram() Method

The RunProgram() method is the method that runs the mode of the user that they want to pursue. The method do not literally means that it is running the program because the one that�s running the program is the main method.  Based from the input of the user from DetermineMode() method earlier, it will run the mode that the user wants to pursue, and also passes the key and characters array which are essential to the methods.
6.1. Encode() Method
       
The Encode() method runs the GetMessage() and OutputKey() methods. After running the GetMessage() method, its value will be passed to the OutputKey() method along with the key array and characters array.
6.1.1. GetMessage() Method

The GetMessage() method gets the message of the user by prompting them to enter their message. It will return the message of the user as its value.
6.1.2. OutputKey() Method
       
The OutputKey() method outputs the key code for the user based on the key array, message array, and character array. First, it will run through each of the letters in the message, then will check the index number of the equivalent letter in the character array, then that index number will be used to output a letter from the key array. If a character from the message is not an alphabetical letter, then it will just simply output whatever that character may be as part of the key code.
6.2 Decode() Method
       
The Decode() method runs the GetKey() and OutputKey() methods. After running the GetKey() method, its value will be passed to the OutputKey() method along with the key array and characters array.
6.2.1 GetKey() Method
       
The GetKey() method gets the key code of the user by prompting them to enter their code. It will return the code of the user as its value.
6.2.2 OutputMessage() Method
       
The OutputMessage() method outputs the message for the user based on the key array, message array, and character array. First, it will run through each of the letters in the key code, then will check the index number of the equivalent letter in the key array, then that index number will be used to output a letter from the characters array. If a character from the key code is not an alphabetical letter, then it will just simply output whatever that character may be as part of the message.
 MP1.txt…]()

MACHINE PROBLEM.xml](https://github.com/user-attachments/files/22624013/20250929.MACHINE.PROBLEM.xml)
<?xml version="1.0"?>
<doc>
    <assembly>
        <name>20250929 MACHINE PROBLEM</name>
    </assembly>
    <members>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.DetermineMode">
            <summary>
            This method determines whether the user wants to encode or decode a message.
            </summary>
            <returns></returns>
        </member>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.GetPassPhrase">
            <summary>
            This method gets the pass phrase from the user.
            </summary>
            <returns></returns>
        </member>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.AssignChars">
            <summary>
            This method assigns the characters A-Z to an array.
            </summary>
            <returns></returns>
        </member>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.AssignPassPhrase(System.String,System.Char[])">
            <summary>
            This method assigns the pass phrase to the key array.
            </summary>
            <param name="passPhrase"></param>
            <param name="characters"></param>
            <returns></returns>
        </member>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.RunProgram(System.String,System.Char[],System.Char[])">
            <summary>
            This method runs the program based on the mode chosen by the user.
            </summary>
            <param name="mode"></param>
            <param name="key"></param>
            <param name="characters"></param>
        </member>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.Encode(System.Char[],System.Char[])">
            <summary>
            This method encodes the message using the key and characters arrays.
            </summary>
            <param name="key"></param>
            <param name="characters"></param>
        </member>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.Decode(System.Char[],System.Char[])">
            <summary>
            This method decodes the message using the key and characters arrays.
            </summary>
            <param name="key"></param>
            <param name="characters"></param>
        </member>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.GetMessage">
            <summary>
            This method gets the message from the user.
            </summary>
            <returns></returns>
        </member>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.GetKey">
            <summary>
            This method gets the key code from the user.
            </summary>
            <returns></returns>
        </member>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.CheckAllArrays(System.Char[],System.Char[])">
            <summary>
            This method sets the sequence of checking the arrays and groups it for easy calling.
            </summary>
            <param name="characters"></param>
            <param name="key"></param>
        </member>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.CheckCharacters(System.Char[])">
            <summary>
            This method is just used for debugging purposes to check the characters array.
            </summary>
            <param name="characters"></param>
        </member>
        <member name="M:_20250929_MACHINE_PROBLEM.Program.CheckKey(System.Char[])">
            <summary>
            This method is just used for debugging purposes to check the key array.
            </summary>
            <param name="key"></param>
        </member>
    </members>
</doc>
