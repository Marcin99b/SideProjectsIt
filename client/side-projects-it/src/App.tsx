import { Box, ChakraProvider } from '@chakra-ui/react';
import React from 'react';

function App() {
  return (
    <ChakraProvider>
      <Box as='button' borderRadius='md' bg='tomato' color='white' px={4} h={8}>
        Button
      </Box>
    </ChakraProvider>
  );
}

export default App;
