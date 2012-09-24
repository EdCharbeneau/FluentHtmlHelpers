#WRITING CUSTOM HTML HELPERS FOR ASP.NET MVC 
*Ed Charbeneau*

##TRANSITIONING FROM WEB FORMS

As a web forms developer I found the transition to MVC was a bit of a shock at first. Without fully understanding the nature of MVC I found the lack of a Toolbox filled with server controls confusing. However once it became clear that the goal of MVC was to expose HTML markup and give developers full control over what is rendered to the browser I quickly embraced the idea.

In MVC development, HTML helpers replace the server control, but the similarities aren’t exactly parallel. Web form’s and server controls were intended to bring the workflow of desktop forms to the web. In MVC HTML helpers provide a shortcut to writing out raw HTML elements that are frequently used.

The HTML helper, in most cases, is a method that returns a string. When called in a View using the razor syntax @Html, we are accessing the Html property of the View which is an instance of the HtmlHelper class.

Writing extensions for the HtmlHelper class will allow us to create our own custom helpers to encapsulate complex HTML markup. Custom helpers promote the use of reusable code and are unit testable. Custom helpers can be configured by passing values to the constructor, via fluent configuration, strongly typed or a combination of and ultimately return a string. 

##HOW TO BEGIN
Reusable Html elements

Alert

HTML, CSS and Javascript
 
##WRITING A SPECIFICATION
First step
Drafting the syntax

##UNIT TESTING
HtmlHelperFactory

Checking the output

##BASIC IMPLEMENTATION
HtmlHelper extension method

Alert constructor

Advanced options

Attributes merge

##FLUENT CONFIGURATION

Appending the spec

Method chaining with interfaces

More testing

##STRONGLY TYPED HELPERS

Appending the spec again

HtmlHelper extension methods again

The ElementFor convention

`<TModel>`

`Expression<Func<T,T>>`

Model Metadata

##FINAL RESULTS
Basic

Fluent

Strongly typed

##CONSIDERATIONS

When to create a helper

When to use basic, fluent, strongly typed or all.

What’s next, templates, and complex controls

Resources