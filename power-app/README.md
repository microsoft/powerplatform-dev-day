# Create Public API Power App

## Prerequisites

* You will need the Public API Custom Connector for this lab.

## Lab

## Create a new Power App

In this section you will create a Power App that will show lists of Public APIs.
    
1. Browse to https://make.powerapps.com
2. Click ***Blank App***
3. Under ***Blank Canvas App*** click ***Create***
4. Enter a name for the application
5. Click ***Create***

* ***Note*** It is important to save a new Power App at least one time in order to take advantage of the auto-save feature.  If you do not save the app at least once, you risk losing all your work.

## Add Public API Connector

In this section, you will add the Public API custom connector to the Power App.
    
1. Click the database icon
2. Click ***Add data***
3. In the Search blank, enter ***Public*** to search for the Public API connector you created.
4. Select the Public API connector to connect it to the Power App.

## Design Power App

In this section, you will add and modify controls to make the Public API Power App

1. In the Tree View, rename Screen1 to ***HomeScreen***

![rename screen](img/RenameScreen.png)

2. Click ***Insert***
3. Click ***Gallery***
4. Click ***Blank vertical***

![blank vertical](img/blankvertical.png)

5. Rename the Gallery1 control to ***gal_APIList***

![rename screen](img/renamegallery.png)

6. In the Tree View delete ***NextArrow1***
7. In the Tree View select ***App***
8. Select the ***OnStart*** property
9. In the function (fx) blank, enter ***ClearCollect(apilist,PublicAPI.List().entries)***

![clearcollect](img/clearcollect.png)

10. Select the ellipsis to the right of ***App*** in the Tree View
11. Click ***Run OnStart***

![run onstart](img/runonstart.png)

12. Click on the ***gal_APIList*** gallery to select it
13. Select ***Data source*** in the properties pane

![gallery](img/datasourcelayout.png)

14. Select the ***apilist*** collection as the gallery datasource
15. Change the Layout from ***Blank*** to ***Title, subtitle, and body***

![gallery](img/gallery.png)

16. Click ***Edit*** to the right of ***Fields*** in the property pane

![edit fields](img/EditFields.png)


17. Change Subtitle1 to ***Description***
18. Change Body1 to ***Link***
19. In the Tree View, rename Title1 to ***lbl_APIName***
20. In the Tree View, rename Subtitle1 to ***lbl_Description***
21. In the Tree View, rename Body1 to ***lbl_Link***

![rename labels](img/lblrenames.png)

22. Select the ***OnSelect*** property of ***lbl_Link***
23. In the fx (function) change ***Select(Parent)*** to ***Launch(ThisItem.Link)***

![label link](img/lbllink.png)

24. Change ***lbl_Link*** to a blue font color
25. Add the Underline font property to lbl_Link

![gallery](img/gallerywithlink.png)

26. Click on ***gal_APIList*** to select it
27. Select the ***OnSelect*** property
28. In the fx (function) enter ***Set(SelectedAPI, ThisItem)***

![gallery onselect](img/galonselect.png)

30. Add a ***Display Form*** to the right of the gallery
31. Set the ***Item*** property of the Display Form to ***SelectedAPI***
32. Click on the Play button to play the app
33. Test any API hyperlink by clicking on it.  A new browser window should open the hyperlink.



