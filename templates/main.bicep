targetScope = 'subscription'


param resourceGroupName string = 'rg-ppdd'
resource rg 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: resourceGroupName
}

module azFunction 'azfunction.bicep' = {
  scope: rg
  name: 'azfunction'
}


