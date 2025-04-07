# Student Management Application

This project is a Student Management Application developed in C#. It provides a user-friendly interface for managing student records, allowing users to view and edit student information.

## Project Structure

- **StudentManagementApp.sln**: Solution file that organizes the project and its components.
- **Program.cs**: Entry point of the application that initializes the main form.
- **App.config**: Configuration settings for the application, including database connection strings.
- **Forms**: Contains the forms used in the application.
  - **Student_Page.cs**: Displays a list of students and allows viewing of individual records.
  - **Student_Page.Designer.cs**: Designer-generated code for the Student_Page form.
  - **StudentPage_Individual.cs**: Displays detailed information about a selected student.
  - **StudentPage_Individual.Designer.cs**: Designer-generated code for the StudentPage_Individual form.
- **Models**: Contains the data models used in the application.
  - **Student.cs**: Represents the student entity with relevant properties.
- **Properties**: Contains assembly-level attributes and resources.
  - **AssemblyInfo.cs**: Assembly-level attributes for the project.
  - **Resources.resx**: Stores application resources such as strings and images.

## Setup Instructions

1. Clone the repository or download the project files.
2. Open the solution file `StudentManagementApp.sln` in your preferred C# development environment.
3. Ensure that the necessary database (StudentInfoDB) is set up and the connection string in `App.config` is correctly configured.
4. Build the solution to restore any dependencies.
5. Run the application to start managing student records.

## Usage Guidelines

- Use the **Student_Page** form to view a list of students. Each student record includes a "VIEW" button to access detailed information.
- The **StudentPage_Individual** form displays comprehensive details about the selected student, including personal information and contact details.

## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue for any enhancements or bug fixes.
