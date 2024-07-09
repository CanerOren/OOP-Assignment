
# Animal and Robot Race OOP Assignment

This assignment simulates a race involving robots and animals. 
Each competitor will start from position 0 on a predefined track of size n+1.The first competitor to reach or surpass position N will be the winner.


Due to the slippery and heavy terrain, competitors occasionally slip or move more slowly. In each round, each competitor will move once. The table below shows the probability of each movement for the competitors. Competitors are not allowed to move or slip back from the starting square.


| Competitor       | Movement Type       | Possibility       | The Movements To Be Performed |
| -------------- | -------------- | -------------- |-------------- |
| Weasel         | Run            | 30%            | 3 Forward     |
|                | Walk           | 50%            | 2 Forward     |
|                | Slip           | 20%            | 4 Backward    |
|Ostrich         | Run            | 50%            | 3 Forward     |
|                | Run Faster     | 20%            | 6 Forward     |
|                | Slip           | 30%            | 4 Backward    |
| Mechanical Elephant         | Walk           | 40%            | 2 Forward     |
|                | Run            | 10%            | 3 Forward     |
|                | Wait           | 50%            | -             |
| SnailBot               | Crawl          | 100%            | 1 Backward    |


Additionally, there will be behavioral interactions among the competitors based on their species:

1) If a Jackal catches up to an Ostrich from behind, there is a 50% chance it will paralyze the Ostrich by hunting it down. A paralyzed Ostrich will not move for the rest of the race.

2) If a Mechanical Elephant catches up to an Ostrich from behind, there is a 20% chance it will paralyze the Ostrich by stepping on its foot. A paralyzed Ostrich will not move for the rest of the race.

3) SnailBots, at the end of their crawling movement, have a 25% chance of bumping into animals at their new position. An animal bumped into will immediately fall back one position in shock. Other than this effect, being bumped into does not impact the animal's ability to continue moving throughout the race.

When any competitor crosses the finish line, the race will end, and all competitors will be ranked and printed on the screen according to their positions at that moment. For each position, the numbers and names of the competitors at that position will be printed. Below are examples of the outputs for two consecutive races.

![Simulation Output](/pics/console_output.png)


Additionally, class diagrams are shown below. 

![Class Diagram](/pics/class_diagram.png)