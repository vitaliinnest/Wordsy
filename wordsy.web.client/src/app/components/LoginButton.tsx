'use client'

import { useMsal } from "@azure/msal-react";
import { loginRequest } from "../authConfig";

export const LoginButton = () => {
  const { instance } = useMsal();

  const handleLogin = () => {
    instance.loginRedirect(loginRequest);
  };

  return <button onClick={handleLogin}>Login with Microsoft / Google</button>;
};
