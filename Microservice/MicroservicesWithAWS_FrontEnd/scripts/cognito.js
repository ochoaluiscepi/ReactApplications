const config={
    cognito:{
        identityPoolId:"us-east-1_w8rcDywq8",
        cognitoDomain:"hotelbookingeast.auth.us-east-1.amazoncognito.com",
        appId:"2eld9jmorai9h75usopl5l9v22"
    }
}

var cognitoApp={
    auth:{},
    Init: function()
    {

        var authData = {
            ClientId : config.cognito.appId,
            AppWebDomain : config.cognito.cognitoDomain,
            TokenScopesArray : ['email', 'openid','profile'],
            RedirectUriSignIn : 'http://localhost:8080/hotel/',
            RedirectUriSignOut : 'http://localhost:8080/hotel/',
            UserPoolId : config.cognito.identityPoolId, 
            AdvancedSecurityDataCollectionFlag : false,
                Storage: null
        };

        cognitoApp.auth = new AmazonCognitoIdentity.CognitoAuth(authData);
        cognitoApp.auth.userhandler = {
            onSuccess: function(result) {
              
            },
            onFailure: function(err) {
            }
        };
    }
}