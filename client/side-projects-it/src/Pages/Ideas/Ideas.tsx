import { Wrap } from '@chakra-ui/react'
import { FC } from 'react'
import { Idea } from '../../Components/Idea/Idea'
import { IdeasMock } from '../../Mocks/IdeasMock'

export const Ideas: FC = () => {
  const mockData = IdeasMock
  return (
    <Wrap spacing={10}>
      {mockData.map((x) => (
        <Idea key={x.id} ideaDto={x} />
      ))}
    </Wrap>
  )
}
