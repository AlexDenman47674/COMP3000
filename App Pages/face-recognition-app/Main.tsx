import react from 'react'

function Untitled(props) {
    return (
      <Container>
        <Rect>
          <SignedInAsUser>Signed in as [USER]</SignedInAsUser>
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
  
  const SignedInAsUser = `
    font-family: Roboto;
    font-style: normal;
    font-weight: 400;
    color: #121212;
    margin-top: 7px;
    margin-left: 190px;
  `;
  
  export default Untitled;


<div>
<h3>Signed in as <h3 i>USER</h3></h3>

<button><h2>Open Camera</h2></button>
<button><h2>Open Database</h2></button>
<button><h2>User Settings</h2></button>
<button><h2>About Us</h2></button>
</div>