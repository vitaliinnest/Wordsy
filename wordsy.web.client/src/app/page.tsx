"use client";

import { useMsal } from "@azure/msal-react";
import { useEffect, useState } from "react";
import { loginRequest } from "./authConfig";
import { LoginButton } from "./components/LoginButton";

export default function Home() {
  const { instance, accounts } = useMsal();
  const [token, setToken] = useState<string | null>(null);

  useEffect(() => {
    if (accounts.length > 0) {
      instance.acquireTokenSilent({ ...loginRequest, account: accounts[0] })
        .then(response => {
          setToken(response.accessToken);
        });
    }
  }, [accounts, instance]);

  return (
    <main>
      {accounts.length === 0 ? (
        <LoginButton />
      ) : (
        <>
          <p>You're logged in as: {accounts[0].username}</p>
          <p>Token: {token?.substring(0, 30)}...</p>
        </>
      )}
    </main>
  );
}
