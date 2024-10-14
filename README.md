# Rectangle Drawing .NET Backend

This is a .NET Core backend for handling rectangle data and validating rectangle dimensions. It provides API endpoints to retrieve, update, and validate rectangle dimensions with artificial delay for validation.

## Features

- API to fetch initial rectangle dimensions stored in a JSON file.
- API to update the rectangle's width and height, including perimeter calculation.
- Backend validation to ensure that the width does not exceed the height.
- Artificial delay of 10 seconds to simulate long-running validation.
- Returns appropriate error messages if validation fails.

## Technologies and Concepts Used

- .NET Core (Backend)
- C# (Programming Language)
- JSON for storing rectangle dimensions
- Dependency Injection
- Layered archtiecture (business logic is handled inside services)

## Setup

### Prerequisites

- .NET SDK installed
- Visual Studio or any other IDE for running the project

### Installation

1. Clone the repository:

    ```bash
    git clone https://github.com/BlinHoxha/rectangle-drawing-net-backend.git
    ```

2. Navigate into the project directory:

    ```bash
    cd rectangle-drawing-net-backend
    ```

3. Restore the necessary packages:

    ```bash
    dotnet restore
    ```

4. Build the project:

    ```bash
    dotnet build
    ```

5. Run the application:

    ```bash
    dotnet run
    ```

### Usage

1. **Fetching Rectangle Data**
   - `GET /rectangle` – Retrieve the current rectangle dimensions from the JSON file.

2. **Updating Rectangle Dimensions**
   - `POST /rectangle` – Update the dimensions of the rectangle (width, height, and perimeter) and perform backend validation.

   ```bash
   curl -X POST "http://localhost:5000/rectangle" -H "Content-Type: application/json" -d '{"width": 50, "height": 100}'
