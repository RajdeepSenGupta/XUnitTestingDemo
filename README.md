# XUnitTestingDemo

This repository contains the basic setup of XUnit testing. 

A. WHAT IS XUNIT TESTING?

xUnit.net is a free, open source, community-focused unit testing tool for the .NET Framework.
All xUnit frameworks share the following basic component architecture, with some varied implementation details -
1. Test Runner: 
  A test runner is an executable program that runs tests implemented using an xUnit framework and reports the test results.
2. Test case:
  A test case is the most elemental class. All unit tests are inherited from here.
3. Test fixtures:
  A test fixture (also known as a test context) is the set of preconditions or state needed to run a test. 
  The developer should set up a known good state before the tests, and return to the original state after the tests.
4. Test suites:
  A test suite is a set of tests that all share the same fixture. The order of the tests shouldn't matter.
5. Test execution:
  The execution of an individual unit test proceeds as follows:
  
    setup(); /* First, we should prepare our 'world' to make an isolated environment for testing */
    ...
    /* Body of test - Here we make all the tests */
    ...
    teardown(); /* At the end, whether we succeed or fail, we should clean up our 'world' to 
    not disturb other tests or code */
    
  The setup() and teardown() methods serve to initialize and clean up test fixtures.
6. Test result formatter:
   test runner produces results in one or more output formats. 
   In addition to a plain, human-readable format, there is often a test result formatter that produces XML output. 
7. Assertions:
  An assertion is a function or macro that verifies the behavior (or the state) of the unit under test. 
  Usually an assertion expresses a logical condition that is true for results expected in a correctly running system under test (SUT). 
  Failure of an assertion typically throws an exception, aborting the execution of the current test.
  

B. HOW TO RUN?

1. Simply install the nuget packages of xUnit by building the project, or running the command 'Update-Package -Reinstall' in the 
   Package Manager Console.
2. Right click on the class file and select 'Run Tests'. 
3. Open 'Test Explorer' and the results of the test will be shown over there.
