# PurgoMalum Test Suite

## Overview

This project tests the PurgoMalum service, which provides profanity filtering for text via JSON, XML, and plain endpoints. The test suite uses [Reqnroll](https://reqnroll.net/) (a fork of SpecFlow) for BDD-style feature testing, integrated with MSTest as the test runner. Tests are written in Gherkin syntax and cover core functionality, error handling, and optional parameters.

## Running the Tests

### Prerequisites

* .NET 8 SDK
* Visual Studio 2022 (recommended)
* All referenced NuGet packages restored

### Steps (Local)

1. Open the solution in Visual Studio 2022.
2. Build the solution to restore dependencies.
3. Open the **Test Explorer** window.
4. Click **Run All** to execute the test suite.

Alternatively, you can run tests from the command line:

```bash
dotnet test --verbosity normal --configuration Release
```

### Steps (GitHub Actions – Manual Trigger)

In addition to running locally, you can also **manually trigger the test suite in GitHub Actions**:

1. Go to the **Actions** tab of this repository.
2. Select the workflow named **Pipeline Tests**.
3. Click the **Run workflow** button in the top-right corner.
4. Choose the branch (default is `main`) and click **Run workflow**.

This will start the pipeline immediately without waiting for a push, pull request, or scheduled run.

## Test Reports

This project is integrated with **GitHub Actions** to automatically generate and publish test reports.

### Retrieving Reports

There are two ways to access the latest test reports:

1. **From GitHub Actions Artifacts**

   * Navigate to the **Actions** tab of this repository.
   * Select the latest workflow run.
   * Scroll down to the **Artifacts** section.
   * Download the report artifact (`Reports`).

2. **From GitHub Pages**

   * The latest HTML report is published to GitHub Pages.
   * Visit:
     [https://delaphante.github.io/PurgoMalum/](https://delaphante.github.io/PurgoMalum/)

### Notes

* Artifacts are always available per-run, while GitHub Pages hosts the most recent report.
* The GitHub Pages URL is automatically updated after each workflow run.
* Manual triggers can also be used to generate and publish reports on demand.

### How to run tests locally

[PurgoMalum2.webm](https://github.com/user-attachments/assets/2206c505-d0ba-4e01-8eae-559ae4d51344)


### How to run tests in CI/CD

[PurgoMalum3.webm](https://github.com/user-attachments/assets/6e36c17f-38ed-4bf7-8ac9-86957abd40f9)

