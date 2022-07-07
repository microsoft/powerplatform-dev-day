
# Deploy Azure Resources

[![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fmicrosoft%2Fpowerplatform-dev-day%2Fmain%2Ftemplates%2Fmain.json)

**Images have been added. Need to list the instructions out!**

1. Click ***Sign In***

    ![sign in](img/sign-in.png)
<!-- <img src="img/sign-in.png"  width="100%" height="300"> -->
2. Expand ***Data***, then click ***Custom Connectors***

    ![navigate to custom connector](img/navigate-to-cc.png)

3. Click ***New Custom Connector***

    ![create new button](img/create-new-cc.png)

4. Click ***Import an OpenAPI from URL***

    ![import button](img/import-cc.png)

5. Click ***Import***, then click ***Continue***

    ![import button](img/import-url.png)

6. You will need to get your Azure Function Base URL from Azure

    ![base url](img/endpoint-url.png)

7. Navigate to [Azure Portal](http://portal.azure.com/), then find your Function App

    ![base url](img/azure-portal.png)

8. Click on the Function App

    ![base url](img/function-app.png)

9. Copy the URL on the Function App

    ![base url](img/function-app-url-location.png)

    *Note you do not need the `https://`*

    ![base url](img/function-app-url.png)

10. Paste the base URL, then click ***Security***

    ![base url](img/endpoint-url-next.png)

11. No authentication is needed for this lab, so you can skip this by clicking ***Definition***

    ![base url](img/security.png)

12. In this section you will see 3 Action in the purple box that were all imported. They will say Run, Run1, Run2. You will need to add a summary and update the ***Operation ID*** to a more friendly name. The ***Operation ID*** is the name of the method/function used in our custom connector. Reference the blue box to know what endpoint you are naming. Here is the list I used.

        1. Category
        2. Random-API
        3. List-API

    ![actions](img/name-endpoints.png)

