# CardMaker

CardMaker is an application that generates graphics via data sources. It has a graphical user interface for designing layouts and offers scripting functionality.

This application was created to help me generate components for a board game. You can put all of your variable data into a CSV or Google Spreadsheet and then create layouts in CardMaker. This separates your layout and data so you do not have to manually re-create each card. 

## Download

Latest stable (I hope) release binary: [Download 1.0.0.2](https://github.com/nhmkdev/cardmaker/releases/tag/v.1.0.0.2)

[Download The Game Crafter templates for CardMaker](https://raw.githubusercontent.com/wiki/nhmkdev/cardmaker/CardMaker_TGC_Templates.zip)

## Sample

![](https://raw.githubusercontent.com/wiki/nhmkdev/cardmaker/readme_sample.png)

The above image was generated by the following input data row from a CSV:

| Count | Name | image | skill1 | skill1value | skill2 | skill2value | ability |
| --- | --- | ---- | ---- | ---- | ---- | ---- | ---- |
| 1 | Siani Malia | che.png | T |  3 | B | 4 | Ranged Battle: +1 on all die Rolls @[opt] | 

While there is some interpretation of the data by CardMaker to generate the final result, many of the values are direct references. The layout configuration in CardMaker controls the details of how to actually present the data.

[Further Details on how the Elements for this Layout are configured](https://github.com/nhmkdev/cardmaker/wiki/user-readme-sample)

## Guides / Help

* [CardMaker User Guides Section](https://github.com/nhmkdev/cardmaker/wiki/user)
* [BoardGameGeek CardMaker Guild](https://www.boardgamegeek.com/guild/2250) - Good place for bugs/request/discussions

Note: The code that is submitted may not match the latest binary.

## Code Status

Compiles with Visual Studio Express Desktop Edition / Visual Studio 2012

See more details in the [Developers Section](https://github.com/nhmkdev/cardmaker/wiki/developers)

[TODO / Wishlist](https://github.com/nhmkdev/cardmaker/wiki/developers-todo)

Toxicity Level: Medium-High
 * Needs more comments
 * Needs warning cleanup
 * Needs some shuffling to allow for more narrow and focused unit testing
 * Needs more unit tests!
 * Every method should be implemented based on an interface and classes should implement hundreds of interfaces (just kidding!!!)

## The Google Issue

If you plan to outright copy the parts of the code that operate with Google Spreadsheets please be aware that the source
currently uses the client id that is associated with my CardMaker application. [Code File](https://raw.githubusercontent.com/nhmkdev/cardmaker/master/CardMaker/Card/Import/GoogleReferenceReader.cs)

You will need to modify this code to correctly use your application.

## Games Developed with CardMaker

CardMaker played some role in the development of these games (not necessarily the final product though!). If you have a game that should be listed here let me know.

[Cave Paintings](http://rnrgames.com/cave-paintings)

## History

2009 - First created and publicly released CardMaker

20XX - Lots of bug fixes and features

2015 - CardMaker goes open source

2017 - CardMaker is finally marked as 1.0.0.0 for no specific reason.

### The Name

"CardMaker" and "Card Maker" are both references to the same application. I just never standardized the name.

## Special Thanks

* Eric Raue
* Kolja Geldmacher
* Everyone that has contributed to the project through emailing bugs and requesting features

## Original Author

CardMaker was originally created in 2009 by Tim Stair.
