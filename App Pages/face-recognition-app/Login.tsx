import React, { Component } from "react";


function Untitled(props) {
  return (
    <Container>
      <Rect>
        <Welcome>Welcome</Welcome>
        <LoremIpsum>Already have an account?</LoremIpsum>
        <Rect2>
          <LogIn>Log In:</LogIn>
        </Rect2>
        <LoremIpsum2>Don&#39;t have an account?</LoremIpsum2>
        <SignUp>Sign Up</SignUp>
      </Rect>
    </Container>
  );
}

const Container = `
  display: flex;
  background-color: rgba(114,189,235,1);
  flex-direction: column;
  height: 100vh;
  width: 100vw;
`;

const Rect = `
  width: 330px;
  height: 558px;
  background-color: rgba(248,249,251,1);
  border-radius: 30px;
  flex-direction: column;
  display: flex;
  margin-top: 40px;
  align-self: center;
`;

const Welcome = `
  font-family: Roboto;
  font-style: normal;
  font-weight: 400;
  color: #121212;
  font-size: 40px;
  margin-top: 18px;
  margin-left: 83px;
`;

const LoremIpsum = `
  font-family: Roboto;
  font-style: normal;
  font-weight: 400;
  color: #121212;
  font-size: 20px;
  margin-top: 87px;
  margin-left: 52px;
`;

const Rect2 = `
  width: 299px;
  height: 180px;
  background-color: rgba(255,251,251,1);
  border-radius: 13px;
  border-width: 1px;
  border-color: #000000;
  flex-direction: column;
  display: flex;
  margin-top: 27px;
  align-self: center;
  border-style: solid;
`;

const LogIn = `
  font-family: Roboto;
  font-style: normal;
  font-weight: 400;
  color: #121212;
  font-size: 20px;
  margin-top: 9px;
  margin-left: 6px;
`;

const LoremIpsum2 = `
  font-family: Roboto;
  font-style: normal;
  font-weight: 400;
  color: #121212;
  font-size: 20px;
  margin-top: 91px;
  align-self: center;
`;

const SignUp = `
  font-family: Roboto;
  font-style: normal;
  font-weight: 400;
  color: #121212;
  font-size: 30px;
  margin-top: 13px;
  margin-left: 114px;
`;

export default Untitled;


<div>
<h2>Welcome</h2>

<h3>Already have an account?</h3>
<div>
    <h3>Log In:</h3>
    <label>
        User Name
        <input type="text" name="User Name" />
        </label>
    <label>
        Password
        <input type="text" password="Password" />
    </label>
    <h3>Don't have an account?</h3>
    <button><h3>Sign Up</h3></button>;
</div>
</div>