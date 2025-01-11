# About This Repository's Contents

## Initial Setup Requirements
The contents of this project's file use Visual Studio 2022 in order to run.
The zip file named `ConversionFormProgram.zip` must be extracted into a workspace of your Visual Studio 2022 application.

## Files and Folders

### File Locations and Namespaces
All of the Forms of this Program are contained with a subfolder named `Forms`. If these are moved out of this subfolder and/or into a different subfolder, all the files with the namespace `ConversionProgram.Forms` must be edited to match the current subfolder where the file is stored. If the file is moved out of the subfolder, just remove .Forms from the appropriate namespaces.

### General Number of Lines in Files
Most of the files of this project are about 100 lines long, without considering any dependencies (such as the Form class that the file `Form1.cs` extends from). This is subject to change as further developments of this project are made.

### Execution Dependencies
The file `Form1.cs` depends on all the other files with the word `Form` in their filename. 
An example of one of the files `Form1.cs` depends on is `AngleForm.cs`. In order to use this program correctly, `Form1.cs` must be in the same project as all the other Forms in this project's zip file.

The Files must be in the same project, but do NOT have to be in the same subfolder. 
If you use alternate subfolders when analyzing this code, please be aware that you must add a `using` statement (as defined by the C# coding language) that specifies the different path in question.

# Credits

This project, and all attached files may be edited in the future by other developers.
As of 12/26/2024, however, I, Nicholas S. Blits, am the only developer responsible for the creation of this program.
Any unwarranted plagiarism of the content of this program that is NOT automatically created by an IDE will result in legal action as is appropriate. 

Visual Studio 2022 by Microsoft Corporation is an example of an IDE as referenced above. 

Please direct any questions either to my email, which is nicholasblits05@yahoo.com , or through messages on my LinkedIn, which can be found at the folllowing link: https://bit.ly/NBlitsLinkedIn 
