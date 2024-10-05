DbTool

DbTool is a C#-based tool designed for database operations, including database connection, script generation, 
and logging activities. This tool is built with modular components to simplify interactions with databases and automate certain operations using Dependency Injection and SOLID Principles.

Project Structure
The project is organized into the following folders and files:

1. Connector
DatabaseConnector.cs: This class handles the connection to the database. It implements the IDatabaseConnector interface and provides the
necessary methods to establish and manage the database connection.

2. Generator
ScriptGenerator.cs: This class is responsible for generating database-related scripts. It implements the IScriptGenerator interface to allow
for customization and management of database scripts (e.g., creating tables, queries, or data migrations).

4. Interfaces
IDatabaseConnector.cs: This interface defines the methods for interacting with a database, which is implemented by DatabaseConnector.cs.
IFileLogger.cs: The interface that defines the logging functionality, which is implemented by the FileLogger class.
IScriptGenerator.cs: This interface outlines the methods for script generation, allowing for flexibility and future extensibility in generating
different kinds of database scripts.

6. Logger
FileLogger.cs: This class implements the IFileLogger interface and is responsible for logging various operations
(such as database connections, errors, or script generation events) to a file. It helps maintain a history of tool activities for debugging or auditing purposes.

8. Program.cs
The entry point for the SignatureDbTool. This file coordinates the overall flow of the tool, initializing the components and executing
the required database operations (such as generating scripts or connecting to the database).
