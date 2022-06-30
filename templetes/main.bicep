targetScope = 'subscription'

param location string = 'centralus'
resource rg 'Microsoft.Resources/resourceGroups@2021-04-01' = {
  name: 'rg-ppdd'
  location: location
}

module azFunction 'azfunction.bicep' = {
  scope: rg
  name: 'azfunction'
}

