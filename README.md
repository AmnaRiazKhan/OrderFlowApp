# Order Processing Application

## Overview

The Order Processing Application is an ASP.NET Core web application that allows customers to enter order amounts and select their customer type ("New" or "Loyal"). The application calculates discounts based on predefined business rules and displays the final order total.

## Table of Contents

- [Getting Started](#getting-started)
- [Building the Application](#building-the-application)
- [Running the Application](#running-the-application)
- [Testing the Application](#testing-the-application)
- [Branching Strategy](#branching-strategy)
- [CI/CD Setup](#cicd-setup)
- [Contributing](#contributing)
- 

## Getting Started

### Prerequisites

Before you begin, ensure that you have the following installed:

- [.NET SDK 8.0](https://dotnet.microsoft.com/download/dotnet/8.0)
- A code editor or IDE (e.g., Visual Studio, Visual Studio Code)
- [Docker](https://www.docker.com/get-started) if you plan to run the application in a container

### Building the Application

To build the application, follow these steps:

1. Clone the repository using following commands:

     git clone https://github.com/yourusername/OrderFlowApp.git
     cd OrderFlowApp
   
3. Restore the dependencies using following command:

     dotnet restore
   
4. Build the application using following command:

     dotnet build

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
   
## Running the Application

You can run the application in various ways:

### Option 1: Using the .NET CLI

To run the application, use the following command:

    dotnet run --project OrderFlowApp

After running the command, you can access the application in your web browser.

### Option 2: Using Docker

If you prefer to run the application in a Docker container, execute:

    docker-compose up --build

Once the container builds and starts, access the application at `http://localhost`.

------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## Testing the Application

To run the automated tests for the application, follow these steps:

1. Navigate to the test project directory:

     cd OrderFlowApp.Tests

2. Run the tests:

     dotnet test

The output will display the results of the tests that validate the discount calculation logic and other functionalities.

----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## Branching Strategy

I utilized a **GitFlow branching strategy** which includes the following main branches:

- **main (or master)**: This branch contains stable code that is always ready for production. It is only updated through pull requests after thorough testing.
  
- **dev_branch**: This branch serves as the primary integration branch for features. Developers create feature branches from this branch.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## CI/CD Setup

The application utilizes **GitHub Actions** for automated CI/CD pipelines. The CI pipeline automatically runs the following on every commit or pull request:

- Restores project dependencies for both the main application and the test projects.
- Builds the application and the test projects.
- Executes the automated tests to verify that all functionalities are working as expected.

The workflow file is located in the `.github/workflows/ci.yml` directory and includes all necessary configurations for the above steps.

-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

## Contributing

Contributions are welcome! If you'd like to contribute to this project, please fork the repository and submit a pull request. Ensure you adhere to the coding standards and write appropriate tests for your changes.
