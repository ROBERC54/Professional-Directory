The Professional Directory, as a database, requires functionality at distinct levels.
MVP-to be usable at all, the software must
	1.Display information to console/Elicit response
	(F)Upon executing the program, the application will communicate with the user via visual messages in the console, until some response from the user takes place.
	2.Accept some instruction from the user via the console
	(F)Upon the user entering some data to the console, the application will interpret user response as indication that execute some function, until that function is complete.
	(F)Given communication that the user wants the app to perform some chosen function, the application will be ready to receive specific parameters necessary to quantify the desired result.
	3.Write to/ read files outside the application 
	(NF)Given a reference to a file on the host system, the app saves that reference for later access.
	(F)Given a request for information, the app shall display to console if relevant files exist on the host system [in the appropriate directory] until the user directs further action.
	(F)Given a request for information, dependent on which documentation is selected, the app shall access files on the host system, using formal logic to determine if the information can be displayed in console.  This is displayed to console until the user designates a means of opening the file.
	(F)Given a specified file, the app shall open it via the appropriate applications selected by the user.
	(F)Given a request to update a text file, the app shall prompt the user to decide whether to append text to the end of the file, or overwrite the file in its entirety, until user chooses.
	(F)Given indication that the user intends to completely overwrite a file, the app will prompt the user for input, until some criteria to stop is met, with the input being written to file.
	(F)Given that the user wishes to append text to a file, the app shall receive some user generated text to write to the end of the file.
	(F)Given some text to append to a text file, the app will hold all input until it is written to the end of the text file.
	4.Display information from the files to console
	(NF)Given the application must work with documentation stored on the host system, the app must recognize a directory for each category of documents, such that no document overlaps multiple areas.
	5.Route user data to the appropriate destination
	(NF)Given more than one entry into the database, the app must store each entry for reference by name, until no more space exists or the entry is marked for deletion.
	(F)Given the user wants to see the available entries, the app will display a list of each to console, that the user may choose which to select/manipulate.
	(NF)Given the user wants to select/manipulate entries, the app will allow for a variety of options to navigate an entry, compare entries, or highlight entries via key commands.
	(NF)Within an entry, the app must hold a variety of key identifiers associated with the entry, distinguishable and orderable by precedence.
	(NF)Given the user wants to select key identifiers, the app will display a list of each to console, that the user may have a standard library of existing keys.
	(F)Within an entry, the app must associate new key identifiers with the entry generated from user input such that accepted keys are distinctive to avoid proliferation of similar keys.
	6.Search accessible information
	(F)Given a specified tag, the app shall iterate through all internal instances that match that tag, such that all instances exist in a loop.
	(F)Given a match to a specified tag, the app will display additional relevant information until the user moves to the next iteration.
	
Full-to be functional/shippable, product must
	1.Store profile info of partners and associates
	(NF)Given multiple entries, the app shall store all entries such that no loss of data occurs in an allocated space.
	2.Pair separate files to individual profiles 
	(NF)Within entries, the app shall hold a list of all files related to the entry that is manageable and alterable.
	(F)Within entries, the app shall be able to reference all files in a list displayable to the user.
	3.Access above document files related to each organization in the profile
	(F)Given a user chosen file, the app will display file type, if it is modifiable within the app, including options to modify via key commands.
	4.Modify/ update documentation without loss of previous version
	(F)Given the user wishes to remove the file from an entry, the app will allow the user to replace it with an updated version, such that the old file is only hidden from view.
	(NF)Given the user elects to update a file, the app only replaces it in the list displayed to user, the internal reference to the file still exists with an 'inaccessible' tag.
	(NF)Given the user can elect to denote a file as taking precedence over a previous file, the app will tag the old file as 'dated' internally.
	(F)Given a file is tagged as 'dated' within an entry, the app will allow the user to toggle whether to see the dated files so long as there exist dated files.
	5.Search profiles for key identifiers/properties
	(NF)Within an entry, the app must hold a variety of key identifiers associated with each file, distinguishable and orderable by precedence.
	(F)Within an entry, the app must associate new key identifiers with each file generated from user input.
	(F)Given a specified identifier within an entry, the app will display only files with that identifier.
	6.Toggle profile properties/special indicators.
	(F)Given a list of properties inherant in a profile, the app will switch off a property the user designates.
Stretch-extend core functionality to
	1.Receive documents from users of various formats
	(F)Given the user wants the app to use a file, the app will store the location of the file for later use.
	(F)Given the user wants to use the file in the app, the app will convert file information to display to console at minimum.
	2.Produce documents of various formats
	(F)Given a file type, the app will produce a stock instance of said type at minimum.
	3.Allow custom key identifiers
	(F)Given the user requires more than the existing keys, the app will allow the user to generate new types of keys from console.
	4.From within a profile, display profiles that share key identifiers
	(F)Within an entry, the app will display like entries as an additional option.
	5.From within a profile, navigate to a related profile
	(F)Given a entry that shares a key, the app will open that entry from within the currently selected profile.
	(F)From a related entry, the app will return to the tangential profile initially selected.
	6.Expand search capabilities to included documentation
	(F)Given a file on the host and a string from the user, the app must extract information from the file matching the given string such that the information extracted encompasses the string plus the preceding/following 'x' characters.
	(F)Given information extracted from a file, the app must hold extracted information until the user designates an operation to perform on that information.
	