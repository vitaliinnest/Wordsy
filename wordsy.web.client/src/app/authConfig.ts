export const msalConfig = {
  auth: {
    clientId: "f2395768-c239-4233-af0c-a6ebc143d672",
    authority: "https://wordsyorg.b2clogin.com/wordsyorg.onmicrosoft.com/B2C_1_susi",
    knownAuthorities: ["wordsyorg.b2clogin.com"],
    redirectUri: "http://localhost:3000",
  },
  cache: {
    cacheLocation: "localStorage",
    storeAuthStateInCookie: false,
  },
};

export const loginRequest = {
  scopes: ["openid", "offline_access", "https://wordsyorg.onmicrosoft.com/api/user_impersonation"]
};
