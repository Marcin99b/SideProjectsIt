import { Box, Tag, TagLabel, Wrap, WrapItem } from '@chakra-ui/react'
import { FC } from 'react'
import { IdeaDto } from '../../Mocks/IdeasMock'

interface IdeaProps {
  ideaDto: IdeaDto
}

export const Idea: FC<IdeaProps> = (props) => {
  const { ideaDto } = props
  return (
    <Box borderWidth="1px" borderRadius="lg">
      <Box p="6">
        <Box mt="1" fontWeight="semibold" as="h4" lineHeight="tight" noOfLines={1}>
          {ideaDto.title}
        </Box>
        <Wrap marginTop={'10px'}>
          {ideaDto.tags.map((x) => (
            <WrapItem key={x}>
              <Tag size="md" key={x} borderRadius="full" variant="solid" colorScheme="green">
                <TagLabel>{x}</TagLabel>
              </Tag>
            </WrapItem>
          ))}
        </Wrap>
        <Box margin={'10px'}>{ideaDto.descriptionShort}</Box>
      </Box>
    </Box>
  )
}
