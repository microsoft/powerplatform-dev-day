targetScope = 'subscription'

param location string = 'Central US'
param resourceGroupName string = 'rg-ppdd'
resource rg 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: resourceGroupName
  location: location
}

module azFunction 'azfunction.bicep' = {
  scope: rg
  name: 'azfunction'
}


