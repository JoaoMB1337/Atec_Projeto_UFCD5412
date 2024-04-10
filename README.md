ADOSMELHORES Asset Management System
Description
This C# program was developed to meet the asset management needs of ADOSMELHORES, a training company. The application provides functionalities to manage information about employees, directors, secretaries, trainers, and coordinators. The program utilizes classes and inheritance to organize and perform the specified tasks.

Classes
Employee

Represents generic information about an employee.
Attributes: ID, name, address, contact, contractEndDate, criminalRecordRegistrationDate.
Director

Represents a director in the company.
Inherits from Employee.
Additional attributes: scheduleExemption, monthlyBonus, companyCar.
Secretary

Represents a secretary in the company.
Inherits from Employee.
Additional attributes: reportedDirector, area.
Trainer

Represents a trainer in the company.
Inherits from Employee.
Additional attributes: taughtArea, availability, hourlyRate.
Coordinator

Represents a coordinator in the company.
Inherits from Employee.
Additional attributes: associatedTrainers (list of trainers).
Additional Features
Validation to ensure data integrity.
Flexibility in trainer availability options (post-labor, labor, or both).
Information about the reported director and area for secretaries.
List of associated trainers for coordinators.
How to Use
Compile and execute the C# program.
Follow the on-screen menu to perform different actions related to asset management.
After each action, the program returns to the initial menu.
License
This program is distributed under the MIT License, granting users the freedom to use, modify, and distribute the software. Contributions are welcome through issues or pull requests.

Acknowledgments
We appreciate your consideration to contribute to the development of this Asset Management System. Your collaboration is essential for the success of this application.
