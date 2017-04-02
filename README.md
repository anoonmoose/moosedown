# moosedown

There are a few options out there for exporting your data our of last.fm, but this is my attempt to devise a free (_as in beer_) and easy (_as in you only need to provide your own api key_) set of tools to perform the following actions:
1. retrieve your data from last.fm in an api-compliant, non-scrapey way
2. store that data persistantly while allowing for updates
3. allow you to write queries of arbitrary complexity (_one liners to complex programs_)

# short instructions
1. Install [LINQPad](https://www.linqpad.net/), open it
2. [Create a connection to a new SQLCE 4.0 database](http://imgur.com/a/EHFOC)
3. Run the "create_table.linq" script on your database
4. **Add your own user name and [api key](https://www.last.fm/api/account/create) to the "moosedown.linq" script - this is an extremely important step**
5. Run the "moosedown.linq" script to build or update your database
6. Use C#, VBScript, F#, or SQL to analyze your database

# short warnings
* no error handling
* only likely to work on 2017-04-02
* worked great when I ran it
