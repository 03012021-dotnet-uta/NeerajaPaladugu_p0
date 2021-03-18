# pizzabox

PizzaBox is a console-based pizza ordering application.

## architecture (REQUIRED)

+ [solution] PizzaBox.sln
  + [project - console] PizzaBox.Client.csproj
  + [project - classlib] PizzaBox.Domain.csproj
    + [folder] Abstracts
    + [folder] Interfaces
    + [folder] Models
    + [folder] Singletons
  + [project - classlib ] PizzaBox.Storing.csproj
    + [folder] Repositories
  + [project - xunit] PizzaBox.Testing.csproj
    + [folder] Tests

## requirements

The application is centered around the interaction of 4 main objects:
- Customer
- Order
- Pizza
- Store

### store

+ [required] there should exist at least 2 stores for a customer to choose from
+ [required] each store should be able to view any and all of their placed orders
+ [required] each store should be able to view any and all of their sales (weekly, monthly, quarterly)

### order

+ [required] each order must be able to modify its collection of pizzas
+ [required] each order must be able to compute its pricing
+ [required] each order must be limited to a total pricing of no more than $250
+ [required] each order must be limited to a collection of pizzas of no more than 50

### pizza

+ [required] each pizza must be able to have a crust
+ [required] each pizza must be able to have a size
+ [required] each pizza must be able to have toppings
+ [required] each pizza must be able to compute its pricing
+ [required] each pizza must have no less than 2 default toppings
+ [required] each pizza must have no more than 5 total toppings

### customer

+ [required] must be able to view its order history
+ [required] must be able to only order from 1 location in a 24-hour period with no reset
+ [required] must be able to only order once in a 2-hour period

## technologies

+ .NET Core - C#
+ .NET Core - EF + SQL
+ .NET Core - xUnit

## timelines

- (DELETE)due on Mar-15 at 11p Central
- present on Mar-17 starting at 9.30a Central
- try to implement as many requirements as you can (don't push to get all done)
- should be an mvp (minimum viable product) status
  - able to at least place an order with 1 pizza
  - able to at least have 10 total validation unit tests for Customer, Order, Pizza, Store
  - able to save a placed order including customer info, pizza info, store info

## as a customer

- should be able to launch application
- should be able to view all stores
- should be able to select a store
- should be to place an order
- should be able to choose either custom or pre-set pizzas

  for a custom pizza
  - should be able to choose crust, size and toppings

  for a preset pizza
  - should be able to choose pizza and size

- should be able to view a preview of the order in progress
- should be able to modify the order in progress (add/remove pizza)
- should be able to place/checkout the order in progress
- should be able to view order history
- should be able to make new order

## store story

as a store, i should be able do this:

+ access the application
+ select options for order history, sales
+ if order history
+ select options for all store orders and orders associated to a user (filtering)

if sales
+ see pizza type, count, revenue by week or by month

> the goal is to try to complete as many reqs as you can in the time alloted. :)
