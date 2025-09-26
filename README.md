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
dotnet test
```

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
     https://delaphante.github.io/PurgoMalum/

### Notes

* Artifacts are always available per-run, while GitHub Pages hosts the most recent report.
* The GitHub Pages URL is automatically updated after each workflow run.
