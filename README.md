## Startdocument for 'Boat rental (Assignment 10)'
Startdocument of **Max Appeldorn**. Student number **5049350**.

### Problem Description
A company rents out speedboats. For any given day, each of the
ten speedboats present, rented out once at most.
A program should be developed that allows the administration of
can be kept in one day. The following data is collected per boat:
recorded: weight, horsepower engine power, length and boat number and the
rent per hour. Furthermore, depending on the amount consumed
fuel a rental surcharge of 5 euros per liter.

For rented
boats are recorded starting time rental, end time rental, number of liters
fuel consumed and damage incurred.
At the end of the day, the owner wants the following data presented
to have:

* The total turnover for all boats;
* The total rental time across all boats;
* The number of the boat with the highest fuel consumption per minute together with this consumption;
* The percentage of the rented boats that have suffered damage;
* The boat that has been rented the shortest.

### Input & Output
In this section the in- and output of the application will be described.

#### Input

###### Boat rental
|Case|Type|Conditions|function/method | additional info|
|-----|----|----------|----------------|----------------|
|name|`string`|not empty|constructor|name of the boat rental|
|rentBoat|`list<rentDay>`||setter|list of days where boats are rented|

###### Rent day
|Case|Type|Conditions|function/method | additional info|
|-----|----|----------|----------------|----------------|
|day|`date`|valid date|constructor, setter|day of rent|
|rentedBoat|`list<rentedBoat>`||setter|list of all the rented boats|

###### Boat
|Case|Type|Conditions|function/method | additional info|
|-----|----|----------|----------------|----------------|
|weight|`double`|not empty|constructor, setter|weight of a boat|
|power|`integer`|not empty, number|constructor, setter|horsepower of a boat|
|length|`integer`|not empty, number|constructor, setter|lengt of a boat|
|number|`integer`|not empty, unique, number|constructor|unique id of a boat|
|rent|`double`|not empty|constructor, setter|price to rent a boat|

###### Rent
|Case|Type|Conditions|function/method | additional info|
|-----|----|----------|----------------|----------------|
|start|`time`|valid time|constructor|rental start time|
|end|`time`|valid time|setter|rental end time|
|literOfFuel|`integer`|not empty, number|setter|number of liters fuel used|
|damage|`integer`|boolean|setter|took damage or not|
|boat|`boat`|valid boat|constructor, setter|boat that is being rented|

#### Output

###### Boat rental
|Case|Type|function/method|
|-----|-----|--------------|
|get the name of a boat rental|`string`|name()|
|get the list of all the boats|`list<Boat>`|boats()|
|get total amount of revenue|`double`|getTotalRevenue()|
|get total rent time|`time`|getTotalRentTime()|
|get number of the boats that use the most fuel per minute|`integer`|getMostConsumer()|
|get shortest time that a boat was rented|`time`|getShortestRent()|

###### Rent day
|Case|Type|Conditions|function/method|
|-----|----|----------|--------------|
|get day|`day`|day()|
|get list of boats that are being rented|`list<boat>`|boat()|

###### Boat
|Case|Type|function/method|
|-----|-----|--------------|
|get weight of a boat|`double`|weight()|
|get horsepower of a boat|`integer`|power()|
|get length of a boat|`integer`|length()|
|get number of a boat|`integer`|number()|
|get rent price of a boat|`double`|rent()|

###### Rented boat
|Case|Type|function/method|
|-----|-----|--------------|
|get start time of the rent|`time`|start()|
|get end time of the rent|`time`|end()|
|get liter of fuel used|`integer`|literOfFuel()|
|get if boat took damage|`boolean`|hasDamage()|
|get boat that is being rented|`boat`|boat()|
|get total rent time|time|calculateRentTime()|
|get total liters of fuel used|integer|calculateFuelUsed()|

## Class Diagram

![image](https://cdn.discordapp.com/attachments/765178991103311873/985985021296935022/erd.png)

## Testplan

#### rent day
|day|rent|
|----|----|
|28-04-2022|[rent1, rent2, rent3]|
|29-04-2022|[rent4, rent5, rent6]|

#### renting a boats
|start|boat|
|-----|-----|
|08:10|boat1|
|09:30|boat2|
|10:00|boat3|
