# Introduction

You are working on a service for film lovers. This service provides its users with the ability to search and manage movie data.

## Problem Statement

Your task is to implement SQL queries that will return valid results about movies to the users.
The application uses in-memory SQLite database instance that is being wiped before each test.
Full schema of each table used in the application is available in an assets/schema directory. The schema should not be modified.

To complete this task you should implement all methods that are throwing `NotImplementedException` in `CategoryRepository` and `MovieReport` classes:

1. The `CategoryRepository.Count` method.
2. The `CategoryRepository.Find` method.
3. The `CategoryRepository.FindAll` method.
4. The `CategoryRepository.FindByName` method
5. The `CategoryRepository.Save` method.
6. The `MovieReport.Get` method.

## Hints
1. Think about preventing invalid input parameters from being passed to the application (and/or database).
2. Use `ArgumentOutOfRangeException` when categoryId<=0 or year parameters are <=0 and `ArgumentException` when fromYear exceeds toYear.
