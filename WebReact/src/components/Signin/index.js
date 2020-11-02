import React from 'react'
import { Container, FormWrap, Icon, FormContent, Form, FormH1, FormLabel, FormInput, FormButton, Text} from './SigninElements';

const Signin = () => {
    return (
        <>
          <Container>
              <FormWrap>
                  <Icon to='/'>logo</Icon>
                  <FormContent>
                      <Form action='#'>
                          <FormH1>Sign in your account</FormH1>
                          <FormLabel htmlFor='for'>Name</FormLabel>
                          <FormInput type='name' required />
                          <FormLabel htmlFor='for'>Password</FormLabel>
                          <FormInput type='password' required/>
                          <FormButton type='submit'>Continue</FormButton>
                          <Text>Forgot password</Text>
                      </Form>
                  </FormContent>
              </FormWrap>
          </Container>  
        </>
    )
}

export default Signin;