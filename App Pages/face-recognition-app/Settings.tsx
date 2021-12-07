import react from 'react'

function Untitled(props) {
    return (
      <Container>
        <Rect>
          <LoggedInAsUser>Logged in as: [USER]</LoggedInAsUser>
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
  
  const LoggedInAsUser = `
    font-family: Roboto;
    font-style: normal;
    font-weight: 400;
    color: #121212;
    margin-top: 11px;
    margin-left: 102px;
  `;
  
  export default Untitled;


<div>
<h3>Signed in as <h3 i>USER</h3></h3>

<div>
    /** Checkbox for showing user details */
    <button><h2>Clear Database</h2></button>
    <button><h2>Change Password</h2></button>

    <button><h2>Sign Out</h2></button>
</div>

</div>