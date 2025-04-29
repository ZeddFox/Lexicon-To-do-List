1. Purpose
Manage the flow of data back and forth between the database and the
web browser

2. Assignment
This is a mandatory assignment you will continue with during week 3.
Share a link to your code on GitHub with me on Friday January 17.
Consider making it a single standalone repository on GitHub so that it
becomes easy to include as a demonstation project in your profile material
(like CV.)

Start a new project in Visual Studio based on the Web API template.

3. Part 1 – controllers
Begin with a focus on three classes – Project, Task and Tag. Store them in a
folder named Models. Keep them simple for now – Id and a string Name.
Add controllers for each of the three classes in the models folder. Add
methods for CRUD (Create, Read, Update, Delete.) Implementation for each
method has to be sketchy at this stage. Make it so the code compiles and
you get some meaningful feedback when testing your routes.
Add the necessary lines to Program.cs.

Use Swagger to test the endpoints of your app. Eventually, we will use
JavaScript to power the frontend. Then we will be able to send application/
json as content-type to our backend. So, your POST methods should be
prepared for this, accepting application/json. 
