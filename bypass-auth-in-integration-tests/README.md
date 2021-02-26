# Bypassing Authentication and Authorization in Integration Tests

When writing integration tests for a web service that has both authentication and authorization,
you either need to configure your test host environment to bypass authentication and authorization,
or hook your test project into a real identity system, e.g. Identity Server. I generally prefer
not to unnecessarily couple my integration tests to a real system in this way - not only does it
pollute said system with configuration specific to the testing of an application, it also slows
the application down (real network calls) and causes tests to fail when there is an outage on the
identity side. Authentication and authorization are important to test, but you don't need to do it
on every integration tset.

This repository demonstrates how to avoid this coupling by bypassing authentication and authorization
constraints in tests.

## DISCLAIMER

The tests don't pass. I just grabbed a sample from the Identity Server 4 samples repository. I'm in
a rush now so will revisit this with a cleaner working example later.
