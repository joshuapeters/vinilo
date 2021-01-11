import React, { ComponentProps } from 'react';
import { Story, Meta }           from '@storybook/react/types-6-0';

import { SubmitButton, SubmitButtonProps } from "@atoms/button-submit";
import { BUTTON_SIZE, BUTTON_TYPE }        from "@core/enums/components/buttons/button-enums";

const ButtonLabel = "Submit";

export default {
    title:      'Vinilo/Components/SubmitButton',
    component:  SubmitButton,
    parameters: { actions: { argTypesRegex: '^on.*' } },
} as Meta;

const Template: Story<ComponentProps<typeof SubmitButton>> = (args: SubmitButtonProps) => (
  <SubmitButton {...args} />
);

export const Primary = Template.bind({});
Primary.args = {
    label: ButtonLabel,
    type:  BUTTON_TYPE.PRIMARY
}

export const Secondary = Template.bind({});
Secondary.args = {
    label: ButtonLabel,
    type:  BUTTON_TYPE.SECONDARY
}

export const Small = Template.bind({});
Small.args = {
    label: ButtonLabel,
    size:  BUTTON_SIZE.SMALL
}

export const Medium = Template.bind({});
Medium.args = {
    label: ButtonLabel,
    size:  BUTTON_SIZE.MEDIUM
}

export const Large = Template.bind({});
Large.args = {
    label: ButtonLabel,
    size:  BUTTON_SIZE.LARGE
}
