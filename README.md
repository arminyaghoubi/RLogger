# Logger NuGet Package

## Overview

The `Logger` NuGet package provides a simple and efficient logging utility for C# applications. It supports asynchronous logging to a file with batch processing to enhance performance. The logger is implemented as a singleton to ensure a single instance throughout the application lifecycle.

## Features

- Singleton pattern to ensure a single instance.
- Asynchronous logging to prevent blocking the main thread.
- Batch processing of logs to improve performance.
- Configurable batch size and log file path.

## Installation

To install the `Logger` NuGet package, use the following command in the NuGet Package Manager Console: NuGet\Install-Package RLogger.2024.06.03 -Version 1.0.0
