# Create Custom Endpoint using Azure Function

## Prerequisites

We encourage you to follow along the hands-on labs during lab sessions.

* If you don't have an Azure Subscription to use for these labs, please create a free subscription at https://azure.microsoft.com/free/.
* Request a power platform developer license [here](https://go.microsoft.com/fwlink/?LinkId=2180357&clcid=0x409).
    * If that doesn't work, please try  [Microsoft 365 Developer Program](https://docs.microsoft.com/en-us/office/developer-program/microsoft-365-developer-program#join-the-microsoft-365-developer-program).

## Lab Part 1 - Azure Resource Deployment

1.  Provision Azure Resources

    In this section you will Provision Azure resources that will host the API. 

    [![Deploy to Azure](https://aka.ms/deploytoazurebutton)](https://portal.azure.com/#create/Microsoft.Template/uri/https%3A%2F%2Fraw.githubusercontent.com%2Fmicrosoft%2Fpowerplatform-dev-day%2Fmain%2Ftemplates%2Fmain.json)

2. If you would like to update the location on where the resources are deployed the update the Location box with what ever region is the closes to you. For location options click [here](https://azure.microsoft.com/en-in/global-infrastructure/geographies/#geographies).

    ![region](img/template.png)

3. Click ***Review + Create***, then click ***Create***

4. When the deployment is complete. Navigate to the Resource Group.

    ![resource group](img/rg-ppdd.png)

5. Click the Function App.

    ![resource group function](img/rg-ppdd-fn.png)

6. On the left hand side, open the deployment center

    ![deployment center](img/deployment-center.png)

7. Select ***External Git***

    ![external git](img/external-git.png)

8. Enter the following information, then click ***Save***:

    * Repository: `https://github.com/ChrisMcKee1/ppdd-azure-function`
    * Branch: `main`

9. Open the logs for the deployment, Click ***Refresh***, Then click on the Commit ID.

    ![logs](img/logs.png)

10. The deployment will take some time to complete. But as long as it looks like this you are good to go to the next section.

    ![deployment](img/deployment.png)

## Lab Part 2 - Create Custom Connector

1. Click ***Sign In***

    ![sign in](img/sign-in.png)
<!-- <img src="img/sign-in.png"  width="100%" height="300"> -->
2. Expand ***Data***, then click ***Custom Connectors***

    ![navigate to custom connector](img/navigate-to-cc.png)

3. Click ***New Custom Connector***

    ![create new button](img/create-new-cc.png)

4. Click ***Import an OpenAPI from URL***

    ![import button](img/import-cc.png)

5. Enter URL: 

    ```
    https://raw.githubusercontent.com/ChrisMcKee1/ppdd-azure-function/main/swagger.json
    ``` 

    Then Click ***Import***  and click ***Continue***

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

    *Informational - All of this information can manually be set up. Since we are using the OpenAPI standard our swagger.json file can do most of the work for us.*

    - If you click on Random-API you will see under the request section that all of the url query parameter are list and you can edit them. This is the information that gets appended to the end of the url to filter the GET request. You can edit each parameter and the expected data types. 

        ![request parameters](img/query-parameters.png) 

    - Under the Response section you can add or edit the response options. 

        ![response](img/response200.png)

    - Inside the response you can see the dynamic response properties that are expected with the type 200 response code. You can have different properties for different response. These body properties are based on a shared reference to a data model.

        ![response body](img/shared-model-references.png) 

    - The location of the data model references can be found here. 

        ![data model](img/shared-model-references-location.png)

13. Click ***Create connector***

    ![create connector](img/create-connector.png)

14. To test your new connector create a new connection

    ![new connection](img/create-test-connection.png)

15. Now test your new connector

    ![test connector](img/test-endpoints.png)

16. Now add it to Power Apps

    ![power apps](img/add-cc-to-powerapp.png)

## Lab Part 3 - Clean Up Azure Resources

*It is important to clean up Azure resources when you are done with them. This prevent you from accumulating charges on your Azure account.*

1. Navigate to the Resource Group.

    ![resource group](img/rg-ppdd.png)

2. CLick delete on the Resource Group.

    ![delete resource group](img/rg-ppdd-delete.png)
