# What is Entity Framework?

**It is an open-source `ORM` (`Object Relational Mapping`) Framework for the .NET applications supported by Microsoft.**

**It simplifies working with databases by mapping your data objects (entities) to the underlying database tables.**

- You can write code using your own objects and EF handles the communication with the database.

## Key advantages of using Entity Framework:

1. **Increased Productivity**: Eliminates the need for writing complex SQL queries, saving time and effort.
2. **Improved Maintainability**: Code becomes more readable and maintainable due to using object-oriented concepts.
3. **Reduced Errors**: EF handles many data access details, reducing the risk of errors compared to manual SQL coding.
4. **Strong Typing**: Improves code accuracy and prevents data type mismatches.
5. **Cross-Platform Support**: EF Core supports various databases and platforms, making it versatile.

## Two main versions of Entity Framework:

1. **`Entity Framework Core` (EF Core)**: Modern, open-source, and cross-platform version actively maintained by Microsoft.
2. **`Entity Framework` (EF)**: Older version primarily used with legacy .NET applications, still supported but not actively developed.

## Choosing the right version:

- For new projects, `EF Core` is generally recommended due to its active development and modern features.
- For existing projects using `EF`, consider migrating to EF Core gradually when feasible.

# What it does:

1. **Maps objects to database tables**: EF automatically translates your C# classes (entities) representing data models to corresponding tables and columns in a database.
   - This eliminates the need for writing tedious SQL queries and data access code.
2. **Simplifies data access**: You can perform CRUD operations (Create, Read, Update, Delete) on data using LINQ queries, a familiar syntax similar to C# code.
   - This makes interacting with data much more natural and less prone to errors compared to raw SQL.
3. **Handles relationships**: EF manages complex relationships between data entities, such as one-to-one, one-to-many, and many-to-many associations, simplifying your data access logic.
4. **Provides change tracking**: EF automatically keeps track of changes made to your data entities, allowing you to save them back to the database efficiently.
5. **Supports migrations**: EF helps manage database schema changes over time by generating migration scripts to update the database structure based on your evolving data model.

## What is Persistance Framework?

**A `persistence framework` is a broader concept than an ORM.**

- It encompasses `any tool` or `library` that helps you persist data, meaning storing and retrieving it in a stable, long-term location.
- While ORMs are a common type of persistence framework.

### Examples of Persistence Frameworks:

1. **Object-Relational Mapping (ORM)**: Entity Framework (EF), SQLAlchemy, Hibernate
2. **NoSQL Object Mapping**: Spring Data JPA, BaaS platforms (Firebase, AWS DynamoDB)
3. **Raw SQL Access**: JDBC, ADO.NET
4. **Data Access Objects (DAO)**: Custom implementations, Spring Data

### **What a Persistence Framework Does:**

1. **Stores and retrieves data**: Its core function is to manage data persistence, ensuring data remains accessible even after program termination or system restarts.
2. **Offers various mechanisms**: It can use different methods to persist data, including:
   - **Object-Relational Mapping (ORM)**: Maps object-oriented models to relational databases, simplifying data access.
   - **Data Access Objects (DAOs):** Provide a layer of abstraction between your code and the underlying data store, often used with raw SQL.
   - **Custom implementations:** You can create your own persistence logic for specific needs.
3. **Additional functionalities:** Many frameworks offer extra features like:
   - **Transaction management:** Ensures data consistency across operations.
   - **Connection pooling:** Improves database performance by managing connections efficiently.
   - **Caching:** Improves data access speed by storing frequently used data in memory.

### Is Persistance Framework and ORM the same?

**`No`**, not exactly.

- ORM is a specific type of persistence framework, but it's not the only type.

**Think of it like this:**

- **Persistence framework**: A toolbox with various tools for storing and retrieving data.
- **ORM**: A specific tool within that toolbox, designed for working with relational databases using objects.

**The terms can be used interchangeably in some contexts, but understanding the subtle differences can help you choose the right tool for your needs.**

### Key differences:

#### **Scope**

- **Persistence framework** is a broader concept, encompassing ORM and other data access methods like a database.

- **ORM** is Specific type of persistence framework.

#### Focus

- **ORM** focuses specifically on object-relational mapping.

- **A persistence framework** can offer additional functionalities beyond mapping.
  - **Transaction management**: Guaranteeing data consistency.
  - **Connection pooling**: Improving performance.
  - **Caching**: Optimizing data access.
  - **Security**: Protecting data integrity.

#### Abstraction level

- **ORM** provides a higher-level abstraction focusing on objects.

- **A persistence framework** can be more granular, allowing for direct manipulation of storage mechanisms.
