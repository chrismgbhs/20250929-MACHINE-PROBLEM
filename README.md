[20250929 MACHINE PROBLEM.xml](https://github.com/user-attachments/files/22624013/20250929.MACHINE.PROBLEM.xml)
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
