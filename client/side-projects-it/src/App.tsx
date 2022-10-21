import { ChakraProvider, Container, TabPanel, TabPanels, Tabs } from '@chakra-ui/react'
import React, { FC } from 'react'
import { Navbar } from './Components/Navbar/Navbar'
import { AddNewIdea } from './Pages/AddNewIdea/AddNewIdea'
import { Ideas } from './Pages/Ideas/Ideas'

export const App: FC = () => {
  return (
    <ChakraProvider>
      <Container maxWidth={'1820px'} marginTop={'15px'}>
        <Tabs variant="soft-rounded" colorScheme="green">
          <Navbar />
          <TabPanels>
            <TabPanel>
              <Ideas />
            </TabPanel>
            <TabPanel>
              <AddNewIdea />
            </TabPanel>
          </TabPanels>
        </Tabs>
      </Container>
    </ChakraProvider>
  )
}
