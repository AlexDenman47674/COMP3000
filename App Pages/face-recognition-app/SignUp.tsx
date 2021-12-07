import react from 'react'

function Untitled(props) {
    return (
      <Container>
        <Rect>
          <Welcome>Welcome</Welcome>
          <Rect2>
            <SignUp2>Sign Up:</SignUp2>
          </Rect2>
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
    margin-top: 39px;
    align-self: center;
  `;
  
  const Welcome = `
    font-family: Roboto;
    font-style: normal;
    font-weight: 400;
    color: #121212;
    font-size: 40px;
    margin-top: 19px;
    margin-left: 83px;
  `;
  
  const Rect2 = `
    width: 299px;
    height: 298px;
    background-color: rgba(255,251,251,1);
    border-radius: 13px;
    border-width: 1px;
    border-color: #000000;
    flex-direction: column;
    display: flex;
    margin-top: 51px;
    margin-left: 16px;
    border-style: solid;
  `;
  
  const SignUp2 = `
    font-family: Roboto;
    font-style: normal;
    font-weight: 400;
    color: #121212;
    font-size: 20px;
    margin-top: 12px;
    margin-left: 7px;
  `;
  
  export default Untitled;


<div>

<div>
    <h3>Sign Up</h3>
    <label>
        User Name
        <input type="text" name="User Name" />
        </label>
    <label>
        Password
        <input type="text" password="Password" />
    </label>
    <button><h3>Get Started</h3></button>;
</div>

</div>