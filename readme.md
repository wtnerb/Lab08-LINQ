# Lab09 LINQ and JSON
### Neighborhoods of New York City
## Overview
This app takes in a provided data file (about neighborhoods in NYC in json format) and processes it to print out only the names of unique, named, non-empty neighborhoods.

## Use
The app itself does not really have any use cases, although bits of the architecture could be useful and are usable.

## Architecture
Because of the straightforward nature of the requirements, the architecture is simple.
1. Use system IO to find the datafile and read it in as a string
2. Use Newtonsoft to parse the JSON into a object that is queryable
3. Use LINQ to query the object according to specifications
4. Iterate across those results and print them to the console

There are no unit tests for this app.

## Libraries
Newtonsoft

## Sources
Newtonsoft documentation