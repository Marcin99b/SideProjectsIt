import { Tab, TabList } from '@chakra-ui/react'
import { FC } from 'react'

export const Navbar: FC = () => {
  return (
    <TabList>
      <Tab
        onClick={() => {
          window.location.pathname = '/'
        }}
      >
        List
      </Tab>
      <Tab
        onClick={() => {
          window.location.pathname = '/add'
        }}
      >
        Add
      </Tab>
    </TabList>
  )
}
