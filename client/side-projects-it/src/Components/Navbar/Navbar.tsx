import { Tab, TabList } from '@chakra-ui/react'
import { FC } from 'react'

export const Navbar: FC = () => {
  return (
    <TabList>
      <Tab>List</Tab>
      <Tab>Add</Tab>
    </TabList>
  )
}
