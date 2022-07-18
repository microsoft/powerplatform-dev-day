targetScope = 'subscription'

param resourceGroupName string = 'rg-ppdd'
param resourceGroupLocation string = 'centralus'
resource rg 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: resourceGroupName
  location: resourceGroupLocation
}

module azFunction 'azfunction.bicep' = {
  scope: rg
  name: 'azfunction'
}
